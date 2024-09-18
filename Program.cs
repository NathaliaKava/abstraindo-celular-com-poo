using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// DONE

Iphone meuIphone = new Iphone("(46) 99901-5911", "13 pro max", "4567", 256);
meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Cifra Club");
meuIphone.InstalarAplicativo("A Palheta Perdida");


Nokia meuNokia = new Nokia("(46) 99901-5911", "Lumia", "2846", 64);
meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("Telegram");
meuNokia.InstalarAplicativo("BitLife");