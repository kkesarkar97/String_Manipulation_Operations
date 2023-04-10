// See https://aka.ms/new-console-template for more information


using StringRelatedProblems;

Console.WriteLine("Enter your String you want to reverse: ");
string str = Console.ReadLine().ToLower();

ReverseString rev = new ReverseString();
rev.reverseString(str);
Console.WriteLine("Enter the Character you want to find count :");
char ch = Convert.ToChar(Console.ReadLine());
OccurrencesOfCharacter count = new OccurrencesOfCharacter();
count.occurrenceCount(str, ch);



Console.WriteLine("Enter the word : ");
string Word = Console.ReadLine().ToLower();
OccurenceOfWords word = new OccurenceOfWords();
word.occurenceWord(str,Word);

DuplicateCharacters duplicate = new DuplicateCharacters();
duplicate.removeDuplicateCharacters(str);
DisplayWordMaxCharacter dw = new DisplayWordMaxCharacter();
dw.findOccurenceCharInWord(str, ch);


