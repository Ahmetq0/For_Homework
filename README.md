### C# For Döngüsü Uygulamaları

##

## 1.Uygulamamız Kullanıcıdan sayı alıp 1 den 10'a kadar çarpım tablosunun sonucunu gösteren uygulamadır

## Örnek Kod:

```C#
public static int Number_Process() {
Console.WriteLine("Sayıyı Giriniz");
return Convert.ToInt32(Console.ReadLine());
}
   
public static void Digital_Process()
{
int number = Number_Process();

for (int i = 0; i <= 10; i++) 
{
Console.WriteLine(number*i);
            }
            
```


## 2.Uygulamamız Kullanıcıdan x bir sayı ve width(genişlik) isteyip bunlarla bir kare çıkartan uygulamadır


## Örnek Kod:

    
```C#

public static void For_Process()
{
int width = Width_and_Height_Selected.Widt_Selected();
int height = Width_and_Height_Selected.Height_Selected();


for (int j = 0; j < width; j++)
{
for (int i = 0; i < width; i++)
{
Console.Write(height);

}
 Console.WriteLine();

```



## 3. Uygulamamız Kullanıcdan bir sayı isteyip 3 sayı genişliğinde ve 5 satır derinliğinde bir dikdörtgen çizdir


## Örnek Kod:

```C#

public static int Number()
{
Console.WriteLine("Sayıyı Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

public static void For_Digital_Process()
{
int number = Number();

for(int a = 0; a < 5; a++)
            {
for(int b = 0; b < 3; b++) 
                {
     Console.Write(number);
                }

     Console.WriteLine();
            }
```


## 4.Uygulamamız Kullanıcıdan bir sembol ve bir genişlik İsteyen ve bu sembolü kullanarak belirtilen genişlik ve yükseklikte üçgen çiz


## Örnek Kod:

```C#
 public static int Width()
 {
     Console.WriteLine("Genişiliği Giriniz");
     return Convert.ToInt32(Console.ReadLine());
 }

 public static int Height() 
 {
    Console.WriteLine("Yüksekliği Giriniz");
     return Convert.ToInt32(Console.ReadLine());
 }

 public static void For_Process()
 {
     int width = Width();
     int height = Height();

     for (int i = width - 1; i >= 0; i--)
     {
         for (int a = 0; a <= i && a <= width; a++)
         {
             Console.Write(height + "");
         }
 Console.WriteLine();
     }
```



## 5.Uygulamamız Kullanıcıdan bir genişlik İsteyen ve Kuzeydoğu üçgeni gösteren programı yazınız

## Örnek Kod:

```C#

public static int Get_Width()
        {
Console.WriteLine("Genişiliği Giriniz");
return Convert.ToInt32(Console.ReadLine());
    }
public static void For_Process()
        {
    int Width = Get_Width();

  for (int i = 0; i < Width; i++)
            {
for (int space = 0; space < i; space++)
                {            Console.Write(" ");
                }
                
            for (int
    multiplacition =
 i; multiplacition <
                <
                
     Width_multiplacition++)
                {
    Console.Write("*");
        }
 Console.WriteLine();
            }
```

## 6.Uygulamamız Kullanıcıdan bDr dize İsteyen ve sağa hizalanmış bir üçgen gösteren program yazınız


## Örnek Kod:


```C#

Console.WriteLine("Bir Dize Giriniz");
string dize = Console.ReadLine();

            for (int i = 0; i < dize.Length; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.Write(dize[j]);
                }
                Console.WriteLine();
            }
```


## 7.Uygulamamız Kullanıcıdan Ditenen bir x aralığı Üçgen y = (x - 4)² fonksiyonunun grafiğini çizen bir program yazınız


## Örnek Kod:

```C#

            string stars = "*";

            Console.WriteLine("Bir sayı giriniz");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i =x ; i < y; i++) 
            {
                int total = (i - 4) * (i - 4);
                Console.WriteLine(stars);
                for (int j =0 ; j < total; j++)
                {
                    Console.Write(stars);
                }
            }
            Console.ReadKey();
```


## 8.Uygulamamız Kullanıcıdan metin İsteyen ve ekrana bir piramit çizen bir program yazınız


## Örnek Kod:


```C#

Console.WriteLine("Bir dize giriniz");
string dize = Console.ReadLine();

for (int i = 0; i <= dize.Length; i++)
            {
for (int a = i; a <= dize.Length; a++)
                {
                    Console.Write(" ");
                }


for (int c = 0; c <= i; c++)
                {
                    Console.Write(dize[c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

```

