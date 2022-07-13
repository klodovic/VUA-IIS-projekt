/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TempServer;

import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import javax.xml.stream.XMLEventReader;
import javax.xml.stream.XMLStreamConstants;
import javax.xml.stream.XMLStreamException;

import javax.xml.stream.events.Characters;
import javax.xml.stream.events.StartElement;
import javax.xml.stream.events.XMLEvent;

/**
 *
 * @author Next Design
 */
class GradParser {

    private static final String URL = "https://vrijeme.hr/hrvatska_n.xml";

    public GradParser() {
    }

    static List<Grad> parse() throws IOException, XMLStreamException {
        List<Grad> gradovi = new ArrayList<>();

        HttpURLConnection con = UrlConnectionFactory.getHttpUrlConnection(URL);
        try (InputStream is = con.getInputStream()) {
            XMLEventReader reader = ParserFactory.createStaxParser(is);

            Optional<TagType> tagType = Optional.empty();
            Grad grad = null;
            StartElement startElement = null;

            while (reader.hasNext()) {
                XMLEvent event = reader.nextEvent();
                switch (event.getEventType()) {
                    case XMLStreamConstants.START_ELEMENT:
                        startElement = event.asStartElement();
                        String qName = startElement.getName().getLocalPart();
                        tagType = TagType.from(qName);
                        break;
                    case XMLStreamConstants.CHARACTERS:
                        if (tagType.isPresent()) {
                            Characters characters = event.asCharacters();
                            String data = characters.getData().trim();
                            switch (tagType.get()) {
                                case GRAD:
                                    grad = new Grad();
                                    gradovi.add(grad);
                                    break;

                                case GRAD_IME:
                                    if (grad != null && !data.isEmpty()) {
                                        grad.setGradIme(data);
                                    }
                                    break;

                                case TEMP:
                                    if (grad != null && !data.isEmpty()) {
                                        grad.setTemp(data);
                                    }
                                    break;
                            }
                        }
                    break;
                }
            }
        }
        return gradovi;
    }

    private enum TagType {

        GRAD("Grad"),
        GRAD_IME("GradIme"),
        TEMP("Temp");

        private final String name;

        private TagType(String name) {
            this.name = name;
        }

        private static Optional<TagType> from(String name) {
            for (TagType value : values()) {
                if (value.name.equals(name)) {
                    return Optional.of(value);
                }
            }
            return Optional.empty();
        }
    }

}
