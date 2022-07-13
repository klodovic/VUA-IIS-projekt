/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package client;

import java.net.MalformedURLException;
import java.net.URL;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;

/**
 *
 * @author programer10
 */
public class TempKlijent {

    /**
     * @param args the command line arguments
     * @throws java.net.MalformedURLException
     * @throws org.apache.xmlrpc.XmlRpcException
     */
    public static void main(String[] args) throws MalformedURLException, XmlRpcException {
        
        XmlRpcClientConfigImpl config = new  XmlRpcClientConfigImpl();
        config.setServerURL(new URL("http://localhost:8080"));
        
        XmlRpcClient client = new XmlRpcClient();
        client.setConfig(config);
        config.setEnabledForExtensions(true);
        
        Object[] parametri = new Object[] {"Knin"};
        String rezultat = (String) client.execute("Metode.getTemp", parametri);
        
        
        System.out.println(rezultat + "C");

    }
    
}
