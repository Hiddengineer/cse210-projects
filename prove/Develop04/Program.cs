using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randActivity  = rnd.Next(0, 3);
        switch (randActivity){
            case 0: 
                BreathingActivity breathing = new BreathingActivity("Breathing",
                    "This activity will help you relax by walking your through breathing in and out slowly."+ 
                    "Clear your mind and focus on your breathing.");
                
                breathing.DisplayStartMessage();
                breathing.DisplayBreathingRhythm();
                breathing.DisplayEndMessage();

            break;

            case 1:
                ReflectionActivity reflection = new ReflectionActivity("Reflecting",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience." + 
                    "This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    new List<Prompt>{new Prompt("Think of a time when you stood up for someone else."),
                        new Prompt("Think of a time when you did something really difficult."),
                        new Prompt("Think of a time when you helped someone in need."),
                        new Prompt("Think of a time when you did something truly selfless.")},
                    new List<Prompt>{new Prompt("Why was this experience meaningful to you?"),
                        new Prompt("Have you ever done anything like this before?"),
                        new Prompt("How did you get started?"),
                        new Prompt("How did you feel when it was complete?"),
                        new Prompt("What made this time different than other times when you were not as successful?"),
                        new Prompt("What is your favorite thing about this experience?"),
                        new Prompt("What could you learn from this experience that applies to other situations?"),
                        new Prompt("What did you learn about yourself through this experience?"),
                        new Prompt("How can you keep this experience in mind in the future?")});

                reflection.DisplayStartMessage();
                reflection.Reflecting();
                reflection.DisplayEndMessage();

            break;

            case 2: 
                ListingActivity listing = new ListingActivity("Listing",
                    "This activity will help you reflect on the good things in your life by having " +
                    "you list as many things as you can in a certain area.",
                    new List<Prompt>{new Prompt("Who are people that you appreciate?"),
                        new Prompt("What are personal strengths of yours?"),
                        new Prompt("Who are people that you have helped this week?"),
                        new Prompt("When have you felt the Holy Ghost this month?"),
                        new Prompt("Who are some of your personal heroes?")});

                listing.DisplayStartMessage();
                listing.DisplayListingActivity();
                listing.DisplayEndMessage();

            break;
        }
    }
}