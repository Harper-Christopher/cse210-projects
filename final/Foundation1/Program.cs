using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._videoTitle = "'Level Up' Your Life - 2 Nephi 26-30";
        video1._author = "Thumb Follow Me";
        video1._length = 244;
        video1.AddComment("John", "These videos are GREAT!");
        video1.AddComment("Sarah", "These are videos the whole family can enjoy.");
        video1.AddComment("Emily", "My kids really like watching these.");
        video1.DisplayVideoDetails();
        
        
        Video video2 = new Video();
        video2._videoTitle = "Ask God - 1 Nephi 11-15";
        video2._author = "Thumb Follow Me";
        video2._length = 183;
        video2.AddComment("Avery", "This video has really good humor with a great message.");
        video2.AddComment("Sophia", "Fantastic video!");
        video2.AddComment("Ethan", "These videos always uplift my day.");
        video2.DisplayVideoDetails();

        Video video3 = new Video();
        video3._videoTitle = "Come Follow Me (March 25-31) Easter HE IS RISEN";
        video3._author = "Line Upon Line - for Come Follow Me";
        video3._length = 1665;
        video3.AddComment("Benjamin", "Great message for the whole family!");
        video3.AddComment("James", "He lives!");
        video3.AddComment("Lucas", "Why look ye for the living among the dead?");
        video3.DisplayVideoDetails();

        Video video4 = new Video();
        video4._videoTitle = "Come Follow Me (January 15-21) 1 Nephi 6-10 THE TREE OF LIFE";
        video4._author = "Line Upon Line - for Come Follow Me";
        video4._length = 675;
        video4.AddComment("Daniel", "The vision of the tree of life is one of my favorites.");
        video4.AddComment("Ava", "Hold onto the iron rod.");
        video4.AddComment("Mia", "Press forward!");
        video4.DisplayVideoDetails();

        Video video5 = new Video();
        video5._videoTitle = "Whats Inside the Temple?";
        video5._author = "Latter Day Kids";
        video5._length = 262;
        video5.AddComment("Lily", "Very spiritual video!");
        video5.AddComment("Olivia", "I love to see the Temple!");
        video5.AddComment("Michael", "Family can be together forever!");
        video5.DisplayVideoDetails();

        Video video6 = new Video();
        video6._videoTitle = "Divine Attributes of Jesus Christ";
        video6._author = "Latter Day Kids";
        video6._length = 300;
        video6.AddComment("David", "Wonderful!");
        video6.AddComment("Taylor", "Prince of Peace!");
        video6.AddComment("Emma", "Great perspective!");
        video6.DisplayVideoDetails();


    }
}