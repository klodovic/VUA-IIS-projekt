/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TempServer;

import java.io.IOException;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.server.PropertyHandlerMapping;
import org.apache.xmlrpc.server.XmlRpcServer;
import org.apache.xmlrpc.server.XmlRpcServerConfigImpl;
import org.apache.xmlrpc.webserver.WebServer;

/**
 *
 * @author programer10
 */
public class Server {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException, XmlRpcException {
        
        System.out.println("Startam server");

        WebServer server = new WebServer(8080);
        
        
        
        XmlRpcServer xmlServer = server.getXmlRpcServer();
        PropertyHandlerMapping phm = new PropertyHandlerMapping();
        phm.addHandler("Metode", Metode.class);
        xmlServer.setHandlerMapping(phm);
        
        //opcionalno
        XmlRpcServerConfigImpl config=(XmlRpcServerConfigImpl) xmlServer.getConfig();
        config.setEnabledForExceptions(true);
        config.setEnabledForExtensions(true);
        config.setContentLengthOptional(false);
        
        //ako će raditi probleme (za projekt) - decimalni broj - ako šaljem decimanli broj ovo mora biti na true
        //config.setEnabledForExceptions(true);
        
        
        
        
        server.start();
        
        System.out.println("Uspješno pokrenut server");
        System.out.println("Čekam zahtjeve");
    }
    
}
