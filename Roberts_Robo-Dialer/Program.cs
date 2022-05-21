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
//BEHAVIORS NOT IMPLEMENTED: None that I know of. 
using Roberts_Robo_Dialer;

Console.WriteLine();

Phone[] Call_List = new Phone[10];
Call_List[0] = new HomePhone("Computest","(303) 985-5060",1);
Call_List[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", 2);
Call_List[2] = new HomePhone("Data Functions", "(800) 876-2524", 1);
Call_List[3] = new HomePhone("Donnay Repair", "(708) 397-3330", 1);
Call_List[4] = new HomePhone("Ergonomic Inc.", "(360) 434-38943", 1);
Call_List[5] = new HomePhone("ErgoSource", "(800) 969-4374", 1);
Call_List[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527", 2);
Call_List[7] = new CellPhone("Glare-Guard", "(800) 545-6254", 2);
Call_List[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", 2);
Call_List[9] = new CellPhone("Komfort Support", "(714) 472-4409", 2);

for (int i = 0; i < Call_List.Length; i++)
{
    Console.WriteLine(Call_List[i].Dial());
}
