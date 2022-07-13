/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TempServer;

import java.io.IOException;
import java.util.List;
import javax.xml.stream.XMLStreamException;

/**
 *
 * @author programer10
 */
public class Metode {

    public String getTemp(String cityName) throws IOException, XMLStreamException{
        
        String temperatura = "";
        List<Grad> gradovi = GradParser.parse();
        
        for (Grad g : gradovi){
            if (cityName.equals(g.getGradIme())) {
                temperatura = cityName + ": " + g.getTemp();
            }
        }
        
     return temperatura;
    }
}
