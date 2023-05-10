using System;
// döngüler
/*
for (int i = 0; i <10; i++)                         // döngüde i değerini sıfır dedik ardından i 'nin 10 'dan küçük olduğunu öğrendik ve i 'nin birer birer artığını gördük
{
    Console.WriteLine("i'nin değerleri: "+i);
}
*/      
int i = 0;                                          // i değerini sıfır olarak atadık
while (i<10)                                        // bir while döngüsü oluşturduk
{
    Console.WriteLine("i'nin değerleri: " + i);
    i++;                                             // döngünün her seferde artmasını sağladık
}