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
import java.io.BufferedReader;
import java.io.File;
import java.io.InputStreamReader;

import com.db4o.ObjectServer;
import com.db4o.config.ConfigScope;
import com.db4o.cs.Db4oClientServer;
import com.db4o.cs.config.ServerConfiguration;

public class Server {
    
    public static final String HOST = "localhost";
    public static final String USER = "";
    public static final String PASSWORD = "";
    public static final int PORT = 11235;

    private static final String SERVER_DB = "server_java.db4o";

    private ObjectServer server;

    public Server() {
        //deleteServerDB();
        startServer();
        System.out.println("> Server started. Enter 'x' to shutdown.");
    }
    
    private void startServer(){
        final ServerConfiguration conf = Db4oClientServer.newServerConfiguration();
        conf.file().generateUUIDs(ConfigScope.GLOBALLY);
        conf.file().generateCommitTimestamps(true);

        server = Db4oClientServer.openServer(conf, Server.SERVER_DB, Server.PORT);
        server.grantAccess(Server.USER, Server.PASSWORD);
    }
    
    public void deleteServerDB(){
        File f = new File(SERVER_DB);
        if (f.exists()) {
            f.delete();
        }
    }
    
    public void shutdownServer(){
        this.server.close();
        //new File(Server.SERVER_DB).delete();
        System.out.println("> Server has shutdown.");
    }
    
    public static void main(final String[] args) throws Throwable {
        final Server server = new Server();
        final BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        while (true) {
            final String input = in.readLine();
            if (input.equals("x")) {
                server.shutdownServer();
                System.exit(0);
            }
        }
    }
}
