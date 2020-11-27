using System;

//seusing System;
using System.Text.RegularExpressions;

//secuencias de caracteres que funcionan como un patron de busqueda
//buscan cadenas de caracteres: letras, numeros, otros
//se usan en validacion de formularios, busqueda de ficheros externos, busquedas de bbdd, comprobacion de entradas de usuario, etc

class MainClass {
  public static void Main (string[] args) {
    string frase = "Mi nombre es Oscar, mi teléfono es (+51)964-744-916, vivo en Surquillo Lima-Perú";
    string patron = "[O]|[S]";
    string w = "[@]";
    string patron_num = @"\d{3}-";//@permite utilizar \, d es para bucar grupode numeros, {3}cantidad de numeros a buscar, - si hay guion 
    //despues del grupo de numeros, 
    //ejemplo de busqueda mas especifica: 
    //@"\d{3}-\{2}-\{2}" = xxx-xx-xx
    //@"\+51" = +51-xxx-xxx-xxx
    //@"\+34|\+44" = (+34)-xxx-xxx-xxx y (+44)-xxx-xxx-xxx

    Regex r =new Regex(patron);
    MatchCollection m = r.Matches(frase);
    if(m.Count > 0) Console.WriteLine("Existe una letra O y S");
    else Console.WriteLine("No existe letra O"); 

    Regex r_num =new Regex(patron_num);
    MatchCollection m_num = r_num.Matches(frase);
    if(m_num.Count > 0) Console.WriteLine("Se ha encontrado un número de teléfono");
    else Console.WriteLine("No se ha encontrado un número de teléfono"); 

    Regex arroba = new Regex(w);
    MatchCollection mc = arroba.Matches(frase);
    if(mc.Count > 0) Console.WriteLine("Hay un arroba");
    else Console.WriteLine("No hay arroba");
  }
}cuencias de caracteres que funcionan como un patron de busqueda
//buscan cadenas de caracteres: letras, numeros, otros
//se usan en validacion de formularios, busqueda de ficheros externos, busquedas de bbdd, comprobacion de entradas de usuario, etc

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}