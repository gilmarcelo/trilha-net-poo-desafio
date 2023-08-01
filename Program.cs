using DesafioPOO.Models;

Nokia smartphoneNokia = new Nokia ("991976177", "nokia", "123456", 64);
Iphone smartphoneIphone = new Iphone("997751519", "iphone", "78900", 124);

smartphoneNokia.Ligar();
smartphoneNokia.ReceberLigacao();
smartphoneNokia.InstalarAplicativo("Nokia");

smartphoneIphone.Ligar();
smartphoneIphone.ReceberLigacao();
smartphoneIphone.InstalarAplicativo("Iphone");