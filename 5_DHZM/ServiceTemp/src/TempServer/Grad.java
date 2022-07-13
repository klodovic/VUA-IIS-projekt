/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TempServer;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;

/**
 *
 * @author Next Design
 */
@XmlAccessorType(XmlAccessType.FIELD)
public class Grad {
    private String gradIme;
    private String temp;

    //Empty const
    public Grad() {
    }
    
    //Const
    public Grad(String gradIme, String temp) {
        this.gradIme = gradIme;
        this.temp = temp;
    }

    //Getters
    public String getGradIme() {
        return gradIme;
    }

    public String getTemp() {
        return temp;
    }

    //Setters
    public void setGradIme(String gradIme) {
        this.gradIme = gradIme;
    }

    public void setTemp(String temp) {
        this.temp = temp;
    }

}

