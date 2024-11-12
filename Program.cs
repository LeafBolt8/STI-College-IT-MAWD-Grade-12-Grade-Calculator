using System;
using System.Threading;//for progress/loading bar source: https://gist.github.com/DanielSWolf/0ab6a96899cc5377bf54

class Program
{//main class

    //for progress/loading bar source: https://gist.github.com/DanielSWolf/0ab6a96899cc5377bf54
    static void Main()
    {//psvm
        Console.Write("");
        using (var progress = new ProgressBar())
        {
            for (int i = 0; i <= 100; i++)
            {
                progress.Report((double)i / 100);
                Thread.Sleep(20);
            }
        }
        Console.WriteLine("Loading done!");
        //for progress/loading bar        

        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine(@"
Welcome to the STI College Grade 12 IT-MAWD Strand Grade Calculator made by Hans Mozol!
This program will provide:
- Visual summary of grades
- Quarterly average
- Overall average
- Rating based from official school criteria. 

Now, how many quarters do you want to input?
    
    Press 1 then Enter if 1st Quarter only 
    Press 2 then Enter if 1st and 2nd Quarter only
    Press 3 then Enter if 1st, 2nd, 3rd Quarter only
    Press 4 then Enter if All 4 quarters");
            //first question

            var quarters = Convert.ToInt32(Console.ReadLine());
            //amount of quarters

            //1ST QUARTER HEHE

            if (quarters == 1)
            {//start of quarter 1 only


                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 4: ");
                var cp4Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 5: ");
                var cp5Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Science: ");
                var phySciQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Education: ");
                var peQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Pagbasa: ");
                var pagbasaQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Practical Research 2: ");
                var pr2Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in EAPP: ");
                var eappQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Personal Development: ");
                var perdevQ1 = Convert.ToDouble(Console.ReadLine());

                var aveQ1 = (cp4Q1 + cp5Q1 + phySciQ1 + peQ1 + pilingQ1 + pagbasaQ1 + pr2Q1 + eappQ1 + perdevQ1) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ1 = (int)aveQ1;
                //converts average to int so decimals cant come hehe
                var firstDigitQ1comp = (aveQ1 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ1comp = (aveQ1 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ1 = (int)firstDigitQ1comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ1 = (int)secondDigitQ1comp;
                //converting it into int so no decimal can come hehe

                //ratings
                string rating = "";
                if (mainDigitQ1 >= 95)
                {
                    rating = "Rating: Very Satisfactory";
                }
                else if (mainDigitQ1 >= 90)
                {
                    rating = "Rating: Satisfactory";
                }
                else if (mainDigitQ1 >= 80)
                {
                    rating = "Rating: Good";
                }
                else if (mainDigitQ1 >= 76)
                {
                    rating = "Rating: Below Average";
                }
                else if (mainDigitQ1 <= 75)
                {
                    rating = "Rating: Failed";
                }

                Console.WriteLine($@"
    
    Grade Summary
                                 Quarter 1
    _________________________________________
    
    Computer Programming 4       {cp4Q1}
    
    Computer Programming 5       {cp5Q1}
    
    Physical Science             {phySciQ1}
    
    Physical Education           {peQ1}
    
    Filipino sa Piling Larangan  {pilingQ1}
    
    Pagbasa                      {pagbasaQ1} 
    
    Practical Research 2         {pr2Q1}
    
    EAPP                         {eappQ1}
    
    Personal Development         {perdevQ1}

    ________________________________________
    
    General Average              {mainDigitQ1}.{firstDigitQ1}{secondDigitQ1}
    Overall Average              {mainDigitQ1}.{firstDigitQ1}{secondDigitQ1}
    {rating}");

                Console.WriteLine(@"
    Click Enter to Continue...");
                Console.ReadLine();

                //USER WOULD LIKE TO TRY AGAIN OR NAHHHHHH


                Console.WriteLine(@"Would you like to use the program once again?
        Click Y is yes, and click N if no (ONLY ACCEPTING CAPITAL LETTERS!!)");

                string response = Console.ReadLine();

                if (response == "Y")
                {
                    continue;
                }
                else if (response == "N")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Did you input right??");
                    repeat = false;
                }







            }//end of quarter 1 only

            if (quarters == 2)
            {//start of quarter 1 and 2 only

                //FIRST QUARTERRRRRRRRRRRRRR    
                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 4: ");
                var cp4Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 5: ");
                var cp5Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Science: ");
                var phySciQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Education: ");
                var peQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Pagbasa: ");
                var pagbasaQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Practical Research 2: ");
                var pr2Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in EAPP: ");
                var eappQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Personal Development: ");
                var perdevQ1 = Convert.ToDouble(Console.ReadLine());

                var aveQ1 = (cp4Q1 + cp5Q1 + phySciQ1 + peQ1 + pilingQ1 + pagbasaQ1 + pr2Q1 + eappQ1 + perdevQ1) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ1 = (int)aveQ1;
                //converts average to int so decimals cant come hehe
                var firstDigitQ1comp = (aveQ1 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ1comp = (aveQ1 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ1 = (int)firstDigitQ1comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ1 = (int)secondDigitQ1comp;
                //converting it into int so no decimal can come hehe
                //FIRST QUARTERRRRRRRRRRRRRR


                //SECOND QUARTERRRRRRRRRRRRRRRRRRRRRRRRRRR
                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Computer Programming 4: ");
                var cp4Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Computer Programming 5: ");
                var cp5Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Physical Science: ");
                var phySciQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Physical Education: ");
                var peQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Pagbasa: ");
                var pagbasaQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Practical Research 2: ");
                var pr2Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in EAPP: ");
                var eappQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Personal Development: ");
                var perdevQ2 = Convert.ToDouble(Console.ReadLine());

                var aveQ2 = (cp4Q2 + cp5Q2 + phySciQ2 + peQ2 + pilingQ2 + pagbasaQ2 + pr2Q2 + eappQ2 + perdevQ2) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ2 = (int)aveQ2;
                //converts average to int so decimals cant come hehe
                var firstDigitQ2comp = (aveQ2 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ2comp = (aveQ2 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ2 = (int)firstDigitQ2comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ2 = (int)secondDigitQ2comp;
                //converting it into int so no decimal can come hehe
                //SECOND QUARTERRRRRRRRRRRRRRRRRRR

                //AVERAGE OF Q1 AND Q2
                var aveQ12 = (cp4Q1 + cp5Q1 + phySciQ1 + peQ1 + pilingQ1 + pagbasaQ1 + pr2Q1 + eappQ1 + perdevQ1 + cp4Q2 + cp5Q2 + phySciQ2 + peQ2 + pilingQ2 + pagbasaQ2 + pr2Q2 + eappQ2 + perdevQ2) / 18;
                var mainDigitQ12 = (int)aveQ12;
                var firstDigitQ12comp = (aveQ12 * 10) / 100;
                var secondDigitQ12comp = (aveQ12 * 100) / 1000;
                var firstDigitQ12 = (int)firstDigitQ12comp;
                var secondDigitQ12 = (int)secondDigitQ12comp;

                //ratings
                string rating = "";
                if (mainDigitQ12 >= 95)
                {
                    rating = "Rating: Very Satisfactory";
                }
                else if (mainDigitQ12 >= 90)
                {
                    rating = "Rating: Satisfactory";
                }
                else if (mainDigitQ12 >= 80)
                {
                    rating = "Rating: Good";
                }
                else if (mainDigitQ12 >= 76)
                {
                    rating = "Rating: Below Average";
                }
                else if (mainDigitQ12 <= 75)
                {
                    rating = "Rating: Failed";
                }

                Console.WriteLine($@"
    
    Grade Summary
                                 Quarter 1         Quarter 2
    ________________________________________________________________
    
    Computer Programming 4          {cp4Q1}                {cp4Q2}
    
    Computer Programming 5          {cp4Q1}                {cp5Q2}
    
    Physical Science                {phySciQ1}                {phySciQ2}
    
    Physical Education              {peQ1}                {peQ2}
    
    Filipino sa Piling Larangan     {pilingQ1}                {pilingQ2}
    
    Pagbasa                         {pagbasaQ1}                {pagbasaQ2} 
    
    Practical Research 2            {pr2Q1}                {pr2Q2}
    
    EAPP                            {eappQ1}                {eappQ2}
    
    Personal Development            {perdevQ1}                {perdevQ2}

    ________________________________________________________________
    
    General Average                {mainDigitQ1}.{firstDigitQ1}{secondDigitQ1}              {mainDigitQ2}.{firstDigitQ2}{secondDigitQ2}
    Overall Average                {mainDigitQ12}.{firstDigitQ12}{secondDigitQ12}
    {rating}");


                Console.WriteLine(@"
    Click Enter to Continue...");
                Console.ReadLine();

                //USER WOULD LIKE TO TRY AGAIN OR NAHHHHHH


                Console.WriteLine(@"Would you like to use the program once again?
            Click Y if yes, and click N if no (ONLY ACCEPTING CAPITAL LETTERS!!)");

                string response = Console.ReadLine();

                if (response == "Y")
                {
                    continue;
                }
                else if (response == "N")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Did you input right??");
                    repeat = false;
                }



            }//end of quarter 1 and 2 only









            if (quarters == 3)
            {//start of quarter 1, 2 and 3 only

                //FIRST QUARTERRRRRRRRRRRRRR    
                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 4: ");
                var cp4Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 5: ");
                var cp5Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Science: ");
                var phySciQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Education: ");
                var peQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Pagbasa: ");
                var pagbasaQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Practical Research 2: ");
                var pr2Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in EAPP: ");
                var eappQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Personal Development: ");
                var perdevQ1 = Convert.ToDouble(Console.ReadLine());

                var aveQ1 = (cp4Q1 + cp5Q1 + phySciQ1 + peQ1 + pilingQ1 + pagbasaQ1 + pr2Q1 + eappQ1 + perdevQ1) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ1 = (int)aveQ1;
                //converts average to int so decimals cant come hehe
                var firstDigitQ1comp = (aveQ1 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ1comp = (aveQ1 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ1 = (int)firstDigitQ1comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ1 = (int)secondDigitQ1comp;
                //converting it into int so no decimal can come hehe
                //FIRST QUARTERRRRRRRRRRRRRR


                //SECOND QUARTERRRRRRRRRRRRRRRRRRRRRRRRRRR
                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Computer Programming 4: ");
                var cp4Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Computer Programming 5: ");
                var cp5Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Physical Science: ");
                var phySciQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Physical Education: ");
                var peQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Pagbasa: ");
                var pagbasaQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Practical Research 2: ");
                var pr2Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in EAPP: ");
                var eappQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Personal Development: ");
                var perdevQ2 = Convert.ToDouble(Console.ReadLine());

                var aveQ2 = (cp4Q2 + cp5Q2 + phySciQ2 + peQ2 + pilingQ2 + pagbasaQ2 + pr2Q2 + eappQ2 + perdevQ2) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ2 = (int)aveQ2;
                //converts average to int so decimals cant come hehe
                var firstDigitQ2comp = (aveQ2 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ2comp = (aveQ2 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ2 = (int)firstDigitQ2comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ2 = (int)secondDigitQ2comp;
                //converting it into int so no decimal can come hehe
                //SECOND QUARTERRRRRRRRRRRRRRRRRRR


                //THIRD QUARTERRRRRRRRRRRRRRRRRRR
                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Computer Programming 4: ");
                var cp4Q3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Computer Programming 5: ");
                var cp5Q3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Physical Science: ");
                var phySciQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Physical Education: ");
                var peQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3rd 3RD QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Pagbasa: ");
                var pagbasaQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Practical Research 2: ");
                var pr2Q3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in EAPP: ");
                var eappQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Personal Development: ");
                var perdevQ3 = Convert.ToDouble(Console.ReadLine());

                var aveQ3 = (cp4Q3 + cp5Q3 + phySciQ3 + peQ3 + pilingQ3 + pagbasaQ3 + pr2Q3 + eappQ3 + perdevQ3) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ3 = (int)aveQ3;
                //converts average to int so decimals cant come hehe
                var firstDigitQ3comp = (aveQ3 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ3comp = (aveQ3 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ3 = (int)firstDigitQ3comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ3 = (int)secondDigitQ3comp;
                //converting it into int so no decimal can come hehe
                //THIRD QUARTERRRRRRRRRRRRRRRRRRRRRR

                //AVERAGE OF Q1 Q2 AND Q3
                var aveQ123 = (cp4Q1 + cp5Q1 + phySciQ1 + peQ1 + pilingQ1 + pagbasaQ1 + pr2Q1 + eappQ1 + perdevQ1 + cp4Q2 + cp5Q2 + phySciQ2 + peQ2 + pilingQ2 + pagbasaQ2 + pr2Q2 + eappQ2 + perdevQ2 + cp4Q3 + cp5Q3 + phySciQ3 + peQ3 + pilingQ3 + pagbasaQ3 + pr2Q3 + eappQ3 + perdevQ3) / 27;
                var mainDigitQ123 = (int)aveQ123;
                var firstDigitQ123comp = (aveQ123 * 10) / 100;
                var secondDigitQ123comp = (aveQ123 * 100) / 1000;
                var firstDigitQ123 = (int)firstDigitQ123comp;
                var secondDigitQ123 = (int)secondDigitQ123comp;

                //ratings
                string rating = "";
                if (mainDigitQ123 >= 95)
                {
                    rating = "Rating: Very Satisfactory";
                }
                else if (mainDigitQ123 >= 90)
                {
                    rating = "Rating: Satisfactory";
                }
                else if (mainDigitQ123 >= 80)
                {
                    rating = "Rating: Good";
                }
                else if (mainDigitQ123 >= 76)
                {
                    rating = "Rating: Below Average";
                }
                else if (mainDigitQ123 <= 75)
                {
                    rating = "Rating: Failed";
                }

                Console.WriteLine($@"
    
    Grade Summary
                                 Quarter 1         Quarter 2         Quarter 3
    ______________________________________________________________________________________________________
    
    Computer Programming 4          {cp4Q1}                {cp4Q2}                   {cp4Q3}                   
    
    Computer Programming 5          {cp5Q1}                {cp5Q2}                   {cp5Q3}                                         
    
    Physical Science                {phySciQ1}                {phySciQ2}                   {phySciQ3}
    
    Physical Education              {peQ1}                {peQ2}                   {peQ3}
    
    Filipino sa Piling Larangan     {pilingQ1}                {pilingQ2}                   {pilingQ3}
    
    Pagbasa                         {pagbasaQ1}                {pagbasaQ2}                   {pagbasaQ3} 
    
    Practical Research 2            {pr2Q1}                {pr2Q2}                   {pr2Q3}
    
    EAPP                            {eappQ1}                {eappQ2}                   {eappQ3}
    
    Personal Development            {perdevQ1}                {perdevQ2}                   {perdevQ3}

    _______________________________________________________________________________________________________
    
    General Average                {mainDigitQ1}.{firstDigitQ1}{secondDigitQ1}              {mainDigitQ2}.{firstDigitQ2}{secondDigitQ2}               {mainDigitQ3}.{firstDigitQ3}{secondDigitQ3}
    Overall Average                {mainDigitQ123}.{firstDigitQ123}{secondDigitQ123}
    {rating}");


                Console.WriteLine(@"
    Click Enter to Continue...");
                Console.ReadLine();

                //USER WOULD LIKE TO TRY AGAIN OR NAHHHHHH


                Console.WriteLine(@"Would you like to use the program once again?
            Click Y if yes, and click N if no (ONLY ACCEPTING CAPITAL LETTERS!!)");

                string response = Console.ReadLine();

                if (response == "Y")
                {
                    continue;
                }
                else if (response == "N")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Did you input right??");
                    repeat = false;
                }

            }//end of quarters 1, 2 and 3 only




            if (quarters == 4)
            {//start of quarter 1, 2, 3, 4 only

                //FIRST QUARTERRRRRRRRRRRRRR    
                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 4: ");
                var cp4Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Computer Programming 5: ");
                var cp5Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Science: ");
                var phySciQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Physical Education: ");
                var peQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Pagbasa: ");
                var pagbasaQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Practical Research 2: ");
                var pr2Q1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in EAPP: ");
                var eappQ1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 1ST QUARTER grade in Personal Development: ");
                var perdevQ1 = Convert.ToDouble(Console.ReadLine());

                var aveQ1 = (cp4Q1 + cp5Q1 + phySciQ1 + peQ1 + pilingQ1 + pagbasaQ1 + pr2Q1 + eappQ1 + perdevQ1) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ1 = (int)aveQ1;
                //converts average to int so decimals cant come hehe
                var firstDigitQ1comp = (aveQ1 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ1comp = (aveQ1 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ1 = (int)firstDigitQ1comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ1 = (int)secondDigitQ1comp;
                //converting it into int so no decimal can come hehe
                //FIRST QUARTERRRRRRRRRRRRRR


                //SECOND QUARTERRRRRRRRRRRRRRRRRRRRRRRRRRR
                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Computer Programming 4: ");
                var cp4Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Computer Programming 5: ");
                var cp5Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Physical Science: ");
                var phySciQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Physical Education: ");
                var peQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Pagbasa: ");
                var pagbasaQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Practical Research 2: ");
                var pr2Q2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in EAPP: ");
                var eappQ2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 2ND QUARTER grade in Personal Development: ");
                var perdevQ2 = Convert.ToDouble(Console.ReadLine());

                var aveQ2 = (cp4Q2 + cp5Q2 + phySciQ2 + peQ2 + pilingQ2 + pagbasaQ2 + pr2Q2 + eappQ2 + perdevQ2) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ2 = (int)aveQ2;
                //converts average to int so decimals cant come hehe
                var firstDigitQ2comp = (aveQ2 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ2comp = (aveQ2 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ2 = (int)firstDigitQ2comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ2 = (int)secondDigitQ2comp;
                //converting it into int so no decimal can come hehe
                //SECOND QUARTERRRRRRRRRRRRRRRRRRR


                //THIRD QUARTERRRRRRRRRRRRRRRRRRR
                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Computer Programming 4: ");
                var cp4Q3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Computer Programming 5: ");
                var cp5Q3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Physical Science: ");
                var phySciQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Physical Education: ");
                var peQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3rd 3RD QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Pagbasa: ");
                var pagbasaQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Practical Research 2: ");
                var pr2Q3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in EAPP: ");
                var eappQ3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 3RD QUARTER grade in Personal Development: ");
                var perdevQ3 = Convert.ToDouble(Console.ReadLine());

                var aveQ3 = (cp4Q3 + cp5Q3 + phySciQ3 + peQ3 + pilingQ3 + pagbasaQ3 + pr2Q3 + eappQ3 + perdevQ3) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ3 = (int)aveQ3;
                //converts average to int so decimals cant come hehe
                var firstDigitQ3comp = (aveQ3 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ3comp = (aveQ3 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ3 = (int)firstDigitQ3comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ3 = (int)secondDigitQ3comp;
                //converting it into int so no decimal can come hehe
                //THIRD QUARTERRRRRRRRRRRRRRRRRRRRRR

                //FOURTH QUARTERRRRRRRRRRRRRRRRRRR
                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Computer Programming 4: ");
                var cp4Q4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Computer Programming 5: ");
                var cp5Q4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Physical Science: ");
                var phySciQ4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Physical Education: ");
                var peQ4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Filipino sa Piling Larangan: ");
                var pilingQ4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Pagbasa: ");
                var pagbasaQ4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Practical Research 2: ");
                var pr2Q4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in EAPP: ");
                var eappQ4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(@"
Enter your 4TH QUARTER grade in Personal Development: ");
                var perdevQ4 = Convert.ToDouble(Console.ReadLine());

                var aveQ4 = (cp4Q4 + cp5Q4 + phySciQ4 + peQ4 + pilingQ4 + pagbasaQ4 + pr2Q4 + eappQ4 + perdevQ4) / 9;
                //average ng q1 (all counted subs)
                var mainDigitQ4 = (int)aveQ4;
                //converts average to int so decimals cant come hehe
                var firstDigitQ4comp = (aveQ4 * 10) / 100;
                //gets first decimal my getting it to hundreds places and dividing by 100 so the ones place (which was the first decimal) will be left
                var secondDigitQ4comp = (aveQ4 * 100) / 1000;
                //gets first decimal my getting it to thousands places and dividing by 1000 so the ones place (which was the second decimal) will be left
                var firstDigitQ4 = (int)firstDigitQ4comp;
                //converting it into int so no decimal can come hehe
                var secondDigitQ4 = (int)secondDigitQ4comp;
                //converting it into int so no decimal can come hehe
                //FOURTH QUARTERRRRRRRRRRRRRRRRRRRRRR

                //AVERAGE OF Q1 Q2 Q3 AND Q4
                var aveQ1234 = (cp4Q1 + cp5Q1 + phySciQ1 + peQ1 + pilingQ1 + pagbasaQ1 + pr2Q1 + eappQ1 + perdevQ1 + cp4Q2 + cp5Q2 + phySciQ2 + peQ2 + pilingQ2 + pagbasaQ2 + pr2Q2 + eappQ2 + perdevQ2 + cp4Q3 + cp5Q3 + phySciQ3 + peQ3 + pilingQ3 + pagbasaQ3 + pr2Q3 + eappQ3 + perdevQ3 + cp4Q4 + cp5Q4 + phySciQ4 + peQ4 + pilingQ4 + pagbasaQ4 + pr2Q4 + eappQ4 + perdevQ4) / 36;
                var mainDigitQ1234 = (int)aveQ1234;
                var firstDigitQ1234comp = (aveQ1234 * 10) / 100;
                var secondDigitQ1234comp = (aveQ1234 * 100) / 1000;
                var firstDigitQ1234 = (int)firstDigitQ1234comp;
                var secondDigitQ1234 = (int)secondDigitQ1234comp;

                string rating = "";
                if (mainDigitQ1234 >= 95)
                {
                    rating = "Rating: Very Satisfactory";
                }
                else if (mainDigitQ1234 >= 90)
                {
                    rating = "Rating: Satisfactory";
                }
                else if (mainDigitQ1234 >= 80)
                {
                    rating = "Rating: Good";
                }
                else if (mainDigitQ1234 >= 76)
                {
                    rating = "Rating: Below Average";
                }
                else if (mainDigitQ1234 <= 75)
                {
                    rating = "Rating: Failed";
                }

                Console.WriteLine($@"
    
    Grade Summary
                                 Quarter 1         Quarter 2         Quarter 3         Quarter 4
    __________________________________________________________________________________________________________________________________
    
    Computer Programming 4          {cp4Q1}                {cp4Q2}                   {cp4Q3}                   {cp4Q4}                   
    
    Computer Programming 5          {cp5Q1}                {cp5Q2}                   {cp5Q3}                   {cp5Q4}                                         
    
    Physical Science                {phySciQ1}                {phySciQ2}                   {phySciQ3}                   {cp5Q4}
    
    Physical Education              {peQ1}                {peQ2}                   {peQ3}                   {cp5Q4}
    
    Filipino sa Piling Larangan     {pilingQ1}                {pilingQ2}                   {pilingQ3}                   {pilingQ4}
    
    Pagbasa                         {pagbasaQ1}                {pagbasaQ2}                   {pagbasaQ3}                   {pagbasaQ4}
    
    Practical Research 2            {pr2Q1}                {pr2Q2}                   {pr2Q3}                   {pr2Q4}
    
    EAPP                            {eappQ1}                {eappQ2}                   {eappQ3}                   {pr2Q4}
    
    Personal Development            {perdevQ1}                {perdevQ2}                   {perdevQ3}                   {pr2Q3}

    ____________________________________________________________________________________________________________________________________
    
    General Average                {mainDigitQ1}.{firstDigitQ1}{secondDigitQ1}              {mainDigitQ2}.{firstDigitQ2}{secondDigitQ2}               {mainDigitQ3}.{firstDigitQ3}{secondDigitQ3}               {mainDigitQ4}.{firstDigitQ4}{secondDigitQ4}
    Overall Average                {mainDigitQ1234}.{firstDigitQ1234}{secondDigitQ1234}
    {rating}
    ");


                Console.WriteLine(@"
    Click Enter to Continue...");
                Console.ReadLine();

                //USER WOULD LIKE TO TRY AGAIN OR NAHHHHHH


                Console.WriteLine(@"Would you like to use the program once again?
            Click Y if yes, and click N if no (ONLY ACCEPTING CAPITAL LETTERS!!)");

                string response = Console.ReadLine();

                if (response == "Y")
                {
                    continue;
                }
                else if (response == "N")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Did you input right??");
                    repeat = false;
                }


            }//end of quarters 1, 2, 3, 4 only

            else
            {
                Console.WriteLine(@"
Try again next time!");
                continue;
            }


        }//for main while loop


    }//psvm
}//main class


//for progress/loading bar source: https://gist.github.com/DanielSWolf/0ab6a96899cc5377bf54
public class ProgressBar : IDisposable, IProgress<double>
{
    private const int blockCount = 10;
    private readonly TimeSpan animationInterval = TimeSpan.FromSeconds(1.0 / 8);
    private const string animation = @"|/-\";

    private readonly System.Timers.Timer timer;
    private double currentProgress = 0;
    private string currentText = string.Empty;
    private bool disposed = false;
    private int animationIndex = 0;

    public ProgressBar()
    {
        timer = new System.Timers.Timer(animationInterval.TotalMilliseconds);
        timer.Elapsed += (sender, e) => TimerHandler();
        timer.AutoReset = false;

        if (!Console.IsOutputRedirected)
        {
            ResetTimer();
        }
    }

    public void Report(double value)
    {
        // Keep value in range [0..1]
        currentProgress = Math.Max(0, Math.Min(1, value));
    }

    private void TimerHandler()
    {
        lock (timer)
        {
            if (disposed) return;

            int progressBlockCount = (int)(currentProgress * blockCount);
            int percent = (int)(currentProgress * 100);
            string text = string.Format("[{0}{1}] {2,3}% {3}",
                new string('#', progressBlockCount), new string('-', blockCount - progressBlockCount),
                percent,
                animation[animationIndex++ % animation.Length]);

            UpdateText(text);
            ResetTimer();
        }
    }

    private void UpdateText(string text)
    {
        Console.Write("\r" + text);
        currentText = text;
    }

    private void ResetTimer()
    {
        timer.Start();
    }

    public void Dispose()
    {
        lock (timer)
        {
            disposed = true;
            Console.Write("\r" + new string(' ', currentText.Length) + "\r");
            timer.Dispose();
        }
    }
}
//for progress/loading bar