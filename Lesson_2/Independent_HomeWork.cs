using System.IO;

namespace OOP_2
{
    internal class Independent_HomeWork
    {
        public string SampleConv(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            text = new string(chars);

            return text;
        }
        public void Files()
        {
            string path = @"C:\GeekBrains\Homework\Lesson_2\Lesson_2\Contacts.txt";
            // Console.WriteLine("Введите текст.");
            // string text = Console.ReadLine();
            //using(FileStream stream = new FileStream(path, FileMode.Open))
            // {
            //     byte[] array = System.Text.Encoding.Default.GetBytes(text);

            //     stream.Write(array, 0, array.Length);
            // }

            //using (FileStream stream1 = File.OpenRead(path))
            //{
            //    byte[] array1 = new byte[stream1.Length];
            //    stream1.Read(array1, 0, array1.Length);


            //    string textFromFile = System.Text.Encoding.Default.GetString(array1);
            //    Console.WriteLine(textFromFile);
            //}


        }
        public string Mail()
        {
            string path = @"C:\GeekBrains\Homework\Lesson_2\Lesson_2\Contacts.txt";
            using (FileStream stream1 = File.OpenRead(path))
            {
                byte[] array1 = new byte[stream1.Length];
                stream1.Read(array1, 0, array1.Length);


                string textFromFile = System.Text.Encoding.Default.GetString(array1);
                //Console.WriteLine(textFromFile);

                string[] email = textFromFile.Split(new char[] { '&', ' ' });
                string[] kezarray = new string[2];
                kezarray[0] =  email[5] ;
                kezarray[1] = email[10];
                string hello = "рш";
                Console.WriteLine(kezarray[0]+" " + kezarray[1]);
                return hello;
            }
        }
    }
}
