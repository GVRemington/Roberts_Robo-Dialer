// See https://aka.ms/new-console-template for more information
//With This New Layout of 2022 VS, 
//I have no clue if these comments are above Namespace, you'll have to let me know. 
//Rayleen Roberts
//IT112
//NOTES: I wasn't sure if you wanted the logic for dialing with a 1 in Cellphone or Phone
//       I chose phone because I assumed you wanted 1 or 2 used as a testing variable
//       and I would have had to write the testing logic in both phones if the logic 
//       for the prepend was in cellphone...I think I would have had to anyway...so 
//       So, I chose phone...since the whole point of these things is not to repeat code.

//       AAAAAND, I was wrong hahaha...I have it the correct way now. Sorry if it seemed like 
//       it was a last minute question, but sometimes I really don't know what I need to ask
//       til I work through it, and I thought I was done days ago until someone questioned 
//       whether we should have it the way I had it, or have cell-phone dial it's own thing. 
//       we discussed it at length over the weekend and we all had different ideas. 
//       it literally took everyone like 3 minutes to fix it, we had the program ready to go (we thought lol)
//       Jace actually had his correct, he was just trying to figure out what the heck he was supposed to 
//       do with the 1 and the 2 within the code. I read and re-read my code and the assignment all the way up to the end
//       to make sure I have it correct and also to see if I could do it better.   :)  Happy Grading. 
//BEHAVIORS NOT IMPLEMENTED: None that I know of. 

using Roberts_Robo_Dialer;

Console.WriteLine();

Phone[] Call_List = new Phone[10];
Call_List[0] = new HomePhone("  Computest","(303) 985-5060",1);
Call_List[1] = new CellPhone("  Curtis Manufacturing", "(603) 532-4123", 2);
Call_List[2] = new HomePhone("  Data Functions", "(800) 876-2524", 1);
Call_List[3] = new HomePhone("  Donnay Repair", "(708) 397-3330", 1);
Call_List[4] = new HomePhone("  Ergonomic Inc.", "(360) 434-38943", 1);
Call_List[5] = new HomePhone("  ErgoSource", "(800) 969-4374", 1);
Call_List[6] = new CellPhone("  Fox Bay Industries", "(800) 874-8527", 2);
Call_List[7] = new CellPhone("  Glare-Guard", "(800) 545-6254", 2);
Call_List[8] = new CellPhone("  Hazard Comm Specialists", "(407) 783-6641", 2);
Call_List[9] = new CellPhone("  Komfort Support", "(714) 472-4409", 2);

for (int i = 0; i < Call_List.Length; i++)
{
    Console.WriteLine(Call_List[i].Dial());
}
