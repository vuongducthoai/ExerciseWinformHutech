/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oodb.db4o;

/**
 *
 * @author turni
 */
import java.io.File;
import java.util.List;

import com.db4o.Db4oEmbedded;
import com.db4o.ObjectContainer;
import com.db4o.ObjectSet;
import com.db4o.config.ConfigScope;
import com.db4o.config.EmbeddedConfiguration;
import com.db4o.cs.Db4oClientServer;
import com.db4o.cs.config.ClientConfiguration;
import com.db4o.drs.Replication;
import com.db4o.drs.ReplicationProvider;
import com.db4o.drs.ReplicationSession;
import com.db4o.drs.db4o.Db4oEmbeddedReplicationProvider;
import com.db4o.query.Query;

public class StorageManager {

    private static final String DB_FILE = "server_java.db4o";

    private ObjectContainer container;
    private final String fileName;

    public StorageManager(final String clientName) {
        this.fileName = clientName + "-" + StorageManager.DB_FILE;
        this.openClientDB();
    }

    public void openClientDB() {
        final EmbeddedConfiguration conf = Db4oEmbedded.newConfiguration();
        conf.file().generateUUIDs(ConfigScope.GLOBALLY);
        conf.file().generateCommitTimestamps(true);
        this.container = Db4oEmbedded.openFile(conf, this.fileName);
    }

    public void closeClientDB() {
        this.container.close();
    }

    public void deleteClientDB() {
        this.closeClientDB();
        this.container = null;
        new File(this.fileName).delete();
    }

    public void beginTransaction() {
        // khong can viet gi.
    }

    public void commitTransaction() {
        this.container.commit();
    }

    public void rollbackTransaction() {
        this.container.rollback();
    }

    public void storeObject(final Object object) {
        this.container.store(object);
    }

    public Query queryData() {
        return this.container.query();
    }

    public <T> List<T> layDoiTuongMau(final Class<?> clazz) {
        final Query query = this.container.query();
        query.constrain(clazz);
        return this.resultQuery(query);
    }

    public <T> List<T> resultQuery(final Query qr) {
        return qr.execute();
    }
    
    private ObjectContainer connectServer() {
        final ClientConfiguration config = Db4oClientServer.newClientConfiguration();
        final ObjectContainer client = Db4oClientServer.openClient(config,
                Server.HOST, Server.PORT, Server.USER, Server.PASSWORD);
        return client;
    }
    
    public void sendToServer() {
        final ObjectContainer client = this.connectServer();
        this.replicateFromTo(this.container, client);
        client.close();
    }

    public void getFromServer() {
        final ObjectContainer client = this.connectServer();
        this.replicateFromTo(client, this.container);
        client.close();
    }

    private void replicateFromTo(final ObjectContainer from, final ObjectContainer to) {
        ReplicationProvider fromRP = new Db4oEmbeddedReplicationProvider(from);
        ReplicationProvider toRP = new Db4oEmbeddedReplicationProvider(to);
        final ReplicationSession replication = Replication.begin(fromRP, toRP);

        final ObjectSet<?> changeSet = fromRP.objectsChangedSinceLastReplication();
        while (changeSet.hasNext()) {
            Object o = changeSet.next();
            replication.replicate(o);
        }

        replication.commit();
        replication.close();
    }

}
