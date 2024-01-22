﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Diagnostics;
using OpenAI_API;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;


namespace PVO
{

    public partial class MainWindow : Window
    {



        private void Close_App(object sender, RoutedEventArgs e)
        {
            Close();
            Test();

        }


        private void TestJson(object sender, RoutedEventArgs e)
        {
            Test();

        }


        public class Person
        {
            public string? FirstName { get; set; } 
            public string? LastName { get; set; }
            public string? JobTitle { get; set; }


        }


 
            public static void Test()
            {
                string text = File.ReadAllText(@"C:\Users\Vista college\source\repos\PVO\PVO\Json\person.json");
                var person = JsonSerializer.Deserialize<Person>(text);

                Console.WriteLine($"First name: {person.FirstName}");
                Console.WriteLine($"Last name: {person.LastName}");
                Console.WriteLine($"Job title: {person.JobTitle}");
                Trace.WriteLine($"First name: {person.FirstName}");
            
        }
        

        public void Internet(object sender, RoutedEventArgs e)
        {
            
            string text = File.ReadAllText(@"C:\Users\Vista college\source\repos\PVO\PVO\Json\person.json");
            var person = JsonSerializer.Deserialize<Person>(text);

            this.MainText.Text = person.FirstName + Environment.NewLine + person.JobTitle ;

        }

        public void Security(object sender, RoutedEventArgs e)
        {

            string text = File.ReadAllText(@"C:\Users\Vista college\source\repos\PVO\PVO\Json\person.json");
            var person = JsonSerializer.Deserialize<Person>(text);

            this.MainText.Text = person.LastName;

        }


            private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {


               
           

            //static async Task Chat(string[] args)
            //{
            //    //authApi
            //    var authentication = new APIAuthentication("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");
            //    var api = new OpenAIAPI(authentication);

            //    // Start a neew chat
            //    var conversation = api.Chat.CreateConversation();

            //    // Add user input and receive a reply from ChatGPT
            //    conversation.AppendUserInput("YOUR_INPUT_HERE");

            //    var response = await conversation.GetResponseFromChatbot();

            //    String user_input = tex


            //}
            
            }



        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Enter)
            {
                //chatr();

                Chatbox.Text = "The post has just arrived and in it a very nice surprise, the discovery that Jacques Seguela, one-time adviser to President Mitterrand, now close confidant of President and Madame Sarkozy (indeed he intoduced them), and something of a legend in French political communications, has dedicated his latest book to little old moi. With apologies for the missing accents here and in the French bits of the long posting which follows - the dedication to 'Le Pouvoir dans la Peau' (Power in the skin) reads 'A Alastair Campbell, mon spin doctor prefere' (three missing accents in one word - mes excuses sinceres). So what did I do for this honour, you are asking? Well, perhaps the fact that he asked me to read his book, and write a 'postface' assessment both of his writing and of the issues he covers, and the fact that I said yes, has something to do with it. He says some blushmakingly kind things in his 'preface to the postface', which I will have to leave to French readers of the whole thing (published by Plon). But for the largely Anglophone visitors of this blog, I thought some of you might like to read the said 'postface' in English (apart from the bits where I quote direct from his book). I hope all those students who write asking for help with dissertations will find something quotable in it. Meanwhile I am off to Norway for a conference and a meeting with the Norwegian Labour Party. I'm looking forward to being in the country with the highest 'human development index' in the world, and which showed such a mature response to the recent massacre of Oslo and Utoya. Here is the postface to Le Pouvoir dans la Peau Jacques Seguela writes about political campaigns and communications not merely as an expert analyst, but as an experienced practitioner. Hence his latest book contains both insights worth heeding, but also enlivening tales of his own experience. He is observer and participant; outsider looking in, and insider looking out.  There is much to look at, not least in France with a Presidential election looming, and the outcome far from easy to predict. We live in a world defined by the pace of change, and whilst the velocity of that change has not always impacted upon our political institutions, many of which would remain recognisable to figures of history, it most certainly has impacted upon political communications. As Seguela writes: ‘En 5 ans le monde de la communication a plus evolue que dans les cents dernieres annees. ' Google, Youtube, Twitter, Facebook have quickly entered our language and changed the way we communicate, live our private lives, do business, do politics. People do not believe politicians as much as they once did. Nor do they believe the media. So who do we believe? We believe each other. The power and the political potential of social networks flows from that reality. Though fiercely modern in their application, social networks in some ways take us back to the politics of the village square. They are an electronic word of mouth on a sometimes global scale. This has changed the way people interact with each other and with their politicians. My first campaign as spokesman and strategist for Tony Blair was in 1997, three years in the planning after he had become leader of the Opposition  Labour Party. Some of the principles of strategy we applied back then would certainly apply to a modern day election. But their tactical execution almost certainly would not. Politicians and their strategists have to adapt to change as well as lead it. Seguela gives some interesting insights into those who have adapted well, and those who have done less well. He clearly adores former President Lula of Brazil and you can feel his yearning for a French leader who can somehow combine hard-headed strategy with human empathy in the same way as a man who left office with satisfaction ratings of 87percent. Seguela probably remains best known in political circles for his role advising Francois Mitterrand. Yet wheras I am 'tribal Labour', and could not imagine supporting a Conservative Party candidate in the UK, Seguela came out as a major supporter of Nicolas Sarkozy. I wonder if one of the reasons was not a frustration that large parts of the left in France remain eternally suspicious of modern communications techniques and styles which, frankly, no modern leader in a modern democracy can ignore. How he or she adapts to, or uses, them is up to them. But you cannot stand aside and imagine the world has not changed. If Lula is a star of this book, so too is Barack Obama. American elections are of enormous interest to all political campaign junkies, a category in which both Seguela and I would almost certainly qualify. Much is made of Obama's use of the internet, a relatively new phenomenon in historical terms and one the young Senator used brilliantly in his quest to become President. Yet though it was an accurate expression of his modernity, underpinning its use were some very old-fashioned campaign principles. He used it to turn supporters into activists who both gave funds and also took his campaign materials and ideas and ran their own campaigns for him. Somehow he managed to make one of the most professional, most disciplined and best funded campaigns in history look like an enormous act of democratic participation. It was less command and control - the model we certainly adopted in 1997 and 2001, Labour's two landslide victories, easing off a little for our third win in 2005 - than 'inspire and empower.'  'Yes we can' not 'yes I can'. His supporters were more than supporters. They were an active part of the campaign, and of the message. The key to this was something that had nothing to do with politicians and everything to do with science, technology and the internet. Ask me who has had the most influence on campaigns in recent times and I might be tempted to reply Tim Berners-Lee, the man credited with gifting the web to the world. Its implications have been far reaching in virtually all aspects of our lives, politics and political campaigns foremost. The new household brand names of the cyber era have not replaced good policy work, messaging and organisation. But they have become essential components of the execution of them in the campaign. Mainstream conventional media remains important and influential, not least because, bizarrely, in most democracies the broadcasters continue to let the press set their agenda for them. But a candidate who tries to stand against the tide of new media will be making a big mistake, and missing big opportunities. If it has changed so much in the last five years, how much more will it change in the next five years? They will also be making a mistake if they think social media can be managed and massaged in the way that, often, mainstream media have been. The key - on this I agree totally with Seguela -  is authenticity. And that should be good news for authentic political leaders and an authenticity hungry public alike. The public tend to get to the point of an election. Seguela has an interesting account of the last UK election and in particular the first ever televised Leaders' Debates. Though I had worked on three campaigns for Tony Blair, I am sufficiently tribally Labour to have answered a call from his successor, Gordon Brown, to go back to help him for his first election campaign as leader in 2011. One of the roles I ended up playing was that of David Cameron in Brown's preparatory sessions for the TV debates. These debates mattered, that much was sure. Election planning for Blair, I had always been doubtful about the benefit of such debates in a Parliamentary democracy where our leaders meet each other week in week out in the crucible of the House of Commons. I was worried the media would make them all about themselves, and that the policy issues would be drowned out. So it proved. Yet in a way the public did get to the point they wanted to. They did not particularly want Labour back after 13 years in power. They did not particularly yearn for David Cameron and a Conservative Party unsure about its direction. So the third party leader emerged through the middle. Nick Clegg was judged the clear winner by the instant reactions of public and media alike. For a few days he seemed impregnable. Yet come the vote, he did not make a huge breakthrough. It was only because neither Labour nor the Tories could get over the line that Clegg ended up as deputy Prime Minister in a coalition government. The country had not been able to make its mind up, delivered a muddled result and asked the leaders to sort it out. The leader who came first and the leader who came third did a deal to do so. I think Seguela is too kind to Cameron. Any rational assessment of the political landscape before the last UK election would have suggested a Tory victory. Labour in power a long time; the economic crash; a Parliament dominated by a scandal involving MPs' expenses; Iraq back in the news because of the official Inquiry; Afghanistan not going well; the press even more strongly in favour of a Tory win than they had been for a Labour win in 1997, and vicious about Brown. Also the Tories had big money to spend on the campaign and Labour did not. Yet Cameron could not secure a majority. Why not? There is no simple answer. The wonder of democracy lies in millions of people having their own experiences, impressions and judgements before deciding how to cast their vote. But the strategist in me says the simple answer is that Cameron lacked real strategic clarity. I think Sequela would agree that for all the changes that technological and mediatic change has forced upon political campaigns, strategy remains the key. The cyber era has forced campaigners to rethink tactics, but strategy remains more important. He and I are clearly in agreement that John McCain's appointment of Sarah Palin as running mate, for example, was a tactical masterstroke, but a strategic catastrophe. Tactically, he excited his base, gave the media a new toy, and momentarily unnnerved his opponent. Strategically he blew a hole through the two central planks of his campaign - experience, and being different from George Bush. In putting tactics before strategy, he broke one of the golden rules of campaigning. Strategists like rules. We like points of principle to act as anchors. I like the rules in Seguela's Chapter 5. On vote pour une idee. Pas pour une ideologie. On vote pour soi. Pas pour son candidat. On vote pour un homme. Pas pour un parti. On vote pour le professionalisme. Pas pour l'amateurisme. On vote pour un projet pas pour le rejet. On vote pour le coeur. Pas pour le rancoeur. On vote pour le futur. Pas pour le passe. On vote pour le bcbg. Pas pour le bling bling. It is charmingly French that he illuminates the rule about voting for le couer pas pour le rancour to a tale of love and sex. 'Si votre femme vous trompe, ce n'est pas en couvrant d'insulte son amant que vous le reconquerez. Mais en lui redonnant envie de vous. La mecanique electorale est le meme, se faire elire c'est se faire preferer.' That may seem glib. But politics is a human business. It is about feelings as well as policies, emotion as well as reason. People often talk about their political leaders as though in a relationship with them. 'He's not listening ... Why on earth did he do that? ... I've gone off him ... Oh, I still like him deep down.' Political leaders sometimes talk of the people in the same way. How many times did I sit in the back of a car with Tony Blair, or fly over Britain in a ‘plane and he would look down and say 'God, I wish I knew what they were thinking ... Do they still like us?' Back at the time of our first landslide, talk of the country 'falling in love' with Blair was widespread. Today, the biggest accusations of betrayal against Blair will often come from those who 'fell in love' most deeply at the outset of his leadership. Perhaps this trend towards relationship politics is being exacerbated by the tendency towards younger leaders. Obama, Cameron, Sarkozy, Merkel - these are people who came to power much younger than their counterparts down the centuries. Seguela, a man of a certain age, remains fascinated by youth and its impact. The brand manager in him can barely disguise his glee that Coca Cola, the drink of the young trendy, is 130 years old. You can sense the excitement he felt on meeting the young Americans - not born when Seguela was advising Mitterrand - who had developed Obama's digital strategy and so helped deliver a mailing list of 13m people. The focus on youth also dominates his analysis of the political consequences of the economic crash whose impact runs through these pages, and offers some fascinating factoids - half of all Europeans are over 50, whilst three quarters of Algerians are under 25. There are as many people under 30 in China as in Russia, the US and Australia combined, and in India twice as many as in China. That too is a powerful force of global change, and will have its impact on Western politics of the future. As to what it all means for the next French elections, I don't know. But this book provides part of the backdrop, economic and political. It should make interesting reading for anyone involved in that campaign. Whilst clearly still of the view Sarkozy was and is the right choice for France, (though the polls at the time of writing indicate he is in a minority) he throws out ideas and challenges for right and left alike. As traditional lines are drawn, careful reading might provoke candidates and parties to see that they should always be looking to the next new ideas, not merely repackaging the last new, let alone the old. I was in Paris recently as a guest of the left think tank, Terra Nova, and met politicians, advisors, militants, experts, journalists and bloggers. I came away with some strong impressions. Firstly, virtually everyone told me that President Sarkozy was hugely unpopular, and his ratings as low as it was possible to go. Yet many of the same people told me he could still win. They know he relishes a campaign. They suspect he may have learned from some mistakes. Incumbency is a powerful weapon. A comeback is a powerful narrative. And they worried that with the President so unpopular, the economy sluggish, social issues raw, and the left in power in many parts of France, the PS should have been doing far better in the polls (to which, incidentally, French politicians and media pay far too much attention.) Of course this was pre selection of a PS candidate. Many of the Socialists agreed with my analysis that once they had chosen the candidate, they needed to unite behind that candidate, resist their historic predilection for factionalism, run a campaign that was fresh, energetic and based upon a programme totally focused on the future and one which addressed people's concerns. They agreed too that the PS could no longer look down its nose at communication, but had to see it not just as an essential element of campaigning, but a democratic duty at a time when people have so many pressures on their lives and living standards, and concerns about the world around them. But though they agreed with the analysis, some worried about the Party’s capacity to deliver upon it. The fear of another defeat ought to be enough, surely, to deliver on the first and essential part: unity. As someone on the progressive side of the political divide, I continue to think the French left's over intellectualisation of politics, its focus on never-ending debate instead of agreement around big points and unity behind one accepted leader remains a problem. I added that I felt the way was wide open for someone to come along and set out, with total honesty and clarity, the challenges ahead, the limitations of what one leader or one country can do, but explain the world and begin to shape direction. In other words, what I sensed behind the seeming confusion and rather disgruntled nature of French opinion was a real desire for leadership of a strategic rather than a tactical nature. There too, there were concerns, not least because of memories of the negative impact on Lionel Jospin’s campaign when he stated – truthfully – that the State could not do everything. I heard a lot about Marine Le Pen and certainly the polls tell a good story for the leader of the Front National. She has certainly shown she can mount a campaign and get the media to accept a sense of change. When even her enemies refer to as Marine, rather than the more toxic Le Pen, that is something of a success. But whenever I have heard her, I have not heard a powerful argument for the future of France. So France enters a fascinating period, where not one single person I met predicted the outcome of either first or second round without at least some doubt in their eyes. When things are so tight, communications can make the difference. It is not a dirty word. I don't agree with all of Seguela’s analysis. I don't accept that only four US presidents radically changed the country. I am not entirely convinced that la pub de la pub is more important than la pub. I am not sure that David Cameron's loss of a child had the political impact Seguela thinks it did. I think Brits will be also be surprised at the dominant role he gives in the Tory campaign to his colleague David Jones. I think he overstates how Sarkozy is seen in the world. I agree with him that we need to be cautious about the potential abuse of the internet which has no global governance or regulation to match, but I'm not sure I agree this risks being  'en bras arme de l'anarchie'. But it is a book full of understanding of some of the big themes and the small details required for a successful campaigning mindset. He is, as one would expect for someone who has been close to different leaders, clued up on the importance of good chemistry between leader and strategist. He understands the importance of body language as well as language. He knows the importance of emotion as well as reason. He understands how the web is changing politics. One of my favourite phrases is that 'life is on the record'. He has a different way of putting it. 'Le \"off\" n'existe plus desormais. Tout ce que vous direz pourra se retourner contre vous.' It is why the whole 'droit d'etre oublie' is emerging as a debate. How many of the young men and women today filling the web with pictures and confessions from their private lives may end up running for office one day, and regretting their openness? On verra. Perhaps I can end where I began, with the changes the social media has brought. At the last election Labour did not do poster campaigns. This was a shame. In previous campaigns we had had some brilliant posters. But under Gordon Brown, we had very little money for the campaign. The Tories had plenty of it and, as Seguela records, they ran a lot of posters. One of their most expensive billboard campaigns was of a giant photo of Cameron with an anti-Labour slogan 'we can't go on like this.' Someone noticed that the Tory leader's face had been airbrushed. This fact became the source of thousands of tweets. Then someone set up a website mydavidcameron.com where people could send their own, largely anti-Tory, versions of this poster. These were sent in in their thousands, and many were much better, wittier and more politically devastating than the original. I'll tell you when I knew they had wasted their money - when the newspapers carried photos of one giant poster site which had been defaced ... Cameron's hair had been replaced with a painted version of Elvis Presley's hair, and to the slogan 'we can't go on like this' had been added the words of one of Elvis' most famous songs ... 'with suspicious minds'. The combination of the internet and wit had reduced the political impact of a hugely expensive campaign to zero. That is my final thought as you begin to read Jacques Seguela’s account. It is a quote from a former colleague, Labour MP Hazel Blears ... 'Campaigning is like sex. If you're not enjoying it, you're not doing it properly.";



            }
        }


        public async Task chatr()
        {

            string user_input = UserInput.Text;

            //authApi
            var authentication = new APIAuthentication("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");
            var api = new OpenAIAPI(authentication);

            // Start a neew chat
            var conversation = api.Chat.CreateConversation();

            // Add user input and receive a reply from ChatGPT
            conversation.AppendUserInput(user_input);

            var response = await conversation.GetResponseFromChatbot();
            
            Chatbox.Text = response;



        }
        


    }

    

}