/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TempServer;

import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.ProtocolException;
import java.net.URL;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.xpath.XPath;
import javax.xml.xpath.XPathExpression;
import javax.xml.xpath.XPathExpressionException;
import javax.xml.xpath.XPathFactory;
import jdk.internal.org.xml.sax.InputSource;

/**
 *
 * @author Next Design
 */
public class FetchTemperatures {

    private static final String URL = "https://vrijeme.hr/hrvatska_n.xml";

    public String getTemp(String cityName) throws MalformedURLException, ProtocolException, IOException, ParserConfigurationException, XPathExpressionException {

        XPathFactory xpathFactory = XPathFactory.newInstance();
        XPath xpath = xpathFactory.newXPath();
        XPathExpression expr = xpath.compile("/Hrvatska/Grad[GradIme='" + cityName + "']/Podatci/Temp");
        InputSource source = new InputSource(getXmlStream());
        String tempResult = expr.evaluate(source);

        return tempResult;
    }
    
        private InputStream getXmlStream() throws MalformedURLException, IOException, ParserConfigurationException {
     
        URL url = new URL(URL); 
        HttpURLConnection connection = (HttpURLConnection) url.openConnection(); 
        connection.setDoOutput(true); 
        connection.setInstanceFollowRedirects(false); 
        connection.setRequestMethod("GET"); 
        connection.setRequestProperty("Content-Type", "application/xml");
        
        InputStream inputStream = connection.getInputStream();
        return inputStream;
    }

}
