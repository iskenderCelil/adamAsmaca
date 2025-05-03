while (true)
{   
    Console.Clear();
    Console.WriteLine("------ADAM ASMACA OYUNUNA HOŞGELDİNİZ-----");
    Console.WriteLine("   TOPLAMDA 6 KERE YANILMA HAKKINIZ VAR");
    char firstMaker = char.ToLower(' ');
     
    List<string> firstSelectedString = new List<string>();
    firstSelectedString.Add("Bugün hava güzel");
    firstSelectedString.Add("Hayat çok iyi");
    firstSelectedString.Add("listelemeyi tam anlayamadım");
    firstSelectedString.Add("kariyerinizi başlatın");
    firstSelectedString.Add("Öğelerin her birini oku");
    Random rnd = new Random();
    string selectedString = firstSelectedString[rnd.Next(firstSelectedString.Count)].ToLower();

    List<char> firstList = new List<char>();

    for (int i = 0; i < selectedString.Length; i++)
    {
        if (selectedString[i] == ' ')
        {
            firstList.Add(' ');
        }
        else if (selectedString[i] == firstMaker)
        {
            firstList.Add(selectedString[i]);
        }
        else
        {
            firstList.Add('_');
        }

    }

    Console.Write("Cümle : ");

    foreach (char c in firstList)
    {
        Console.Write(c);
    }

    int hakk = 6;
     
    while (hakk >= 0)
    {
        if (hakk > 0)
        {
             
            Console.Write("\n\nHarf tahmini için (1)\nCümle tahmini için (2)\nSeçiminiz : ");
            char oneTwo = char.Parse(Console.ReadKey().KeyChar.ToString());

            if (oneTwo == '1')
            {  
                 
                Console.Write("\nLütfen bir harf giriniz: ");
                char inputString = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool trueMaker = false;

                for (int i = 0; i < selectedString.Length; i++)
                {
                    if (selectedString[i] == inputString)
                    {
                        firstList[i] = inputString;
                        trueMaker = true;
                    }
                }

                if (trueMaker == false)
                {
                    Console.Clear();
                    Console.WriteLine($"Seçtiğiniz harf cümlede bulunmuyor.");
                    hakk--;
                }

                if (trueMaker == true)
                {
                    Console.Clear();
                    Console.WriteLine("Doğru harf buldunuz.");
                    foreach (var yaz in firstList)
                    {
                        Console.Write(yaz);
                    }
                }
            }
            else if (oneTwo == '2')
            {
                Console.Write("\nLütfen tahmin ettiğiniz cümleyi giriniz : ");
                var inputSentence = Console.ReadLine().ToLower();
                if (inputSentence == selectedString)
                {  
                    Console.Clear();
                    Console.WriteLine("Doğru cümleyi buldunuz. Tebrikler.");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Cümleler uyuşmuyor.");
                    hakk--;
                }
            }
        }
        
        switch (hakk)
        {
            case 0:
                 
                Console.WriteLine($" |-----|\n"+" @     |  \n/|\\    | Oyun bitti. Kaybettiniz.\n"+"/ \\    |\n      ----");
                break;
            case 1:
                 
                Console.WriteLine($" |-----|\n"+" @     | Kalan hakkınız : 1\n/|\\    |\n"+"       |\n      ----");
                break;
            case 2:
                 
                Console.WriteLine($" |-----|\n"+" @     | Kalan hakkınız : 2\n       |\n"+"       |\n      ----");
                break;
            case 3:
                 
                Console.WriteLine($" |-----|\n"+"       | Kalan hakkınız : 3\n       |\n"+"       |\n      ----");
                break;
            case 4:
                 
                Console.WriteLine($"       |\n"+"       | Kalan hakkınız : 4\n       |\n"+"       |\n      ----");
                break;
            case 5:
                 
                Console.WriteLine($"        \n"+"         Kalan hakkınız : 5\n        "+"        \n      ----");
                break;
        }

        if (hakk == 0)
        {
            break;
        }
    }  
     
    Console.Write("Tekrar oynamak ister misiniz? (e/h) ");
    char control = char.ToLower(Console.ReadKey().KeyChar);
     
    if (control != 'e')
    {   
        Console.Clear();
        Console.WriteLine("Oyun kapatılıyorrrrr");
        break;
    }
}
