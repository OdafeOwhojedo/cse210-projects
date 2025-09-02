using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;//A list that contains the prompts the user will respond to.
    public PromptGenerator()//This constructor initializes and pre-populate the list with prompts for the user.
    {
        _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today what would it be?", "Have I done my 'Come Follow Me' assignment today and how did my assignment helped strenghted my testimony?", "What spiritual experience did i gain from reading the Book of Mormon today?", "How did my saying my prayers today improve my relationship with Heavenly Fathe and my savior Jesus Christ?", "What step(s) did I take today to be more temple worthy?", "What did I do right today to hear more from the Lord?", "What step did I take today to achieve my next temple worship?", "What did I do today to be the hand of the Lord?", "What step(s) did I take today to be closer to my family?","What specific plans and decisions did I take today to accomplished my Ministry assignment?", "What did I do well to be able to minister to the one?", "What did I do today to strenghten my financial future?", "What spiritual impressions did i felt today from reading, listening or watching a talk or article from the general authorities?", "What did I do today to follow the admonishion of President Russell M. Nelson"};
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();//Create a new random class object.
        int promptPosition = randomPrompt.Next(0, _prompts.Count);//Randomly pick an interger value that will indicate the position of a prompt in the prompt list.
        string latestPrompt = _prompts[promptPosition];//Pick a prompt by its interger position and assigned it to the string variable.
        return latestPrompt;
    }
}