using NewsPublisher.Core.Entities;
using NewsPublisher.Core.Interfaces;
using System.Collections.Generic;

namespace NewsPublisher.Infrastructure.SourceServices
{
    public class PressTrustIndiaProvider : INewsSourceProvider
    {
        public List<NewsContentEntity> GetNewsContents()
        {
            var newsContentEnitityList = new List<NewsContentEntity>
            {
                new NewsContentEntity
                {
                    Category = "Business",
                    Description = @" Renewable energy ministry has proposed customs duties on some solar power equipment starting August 1 as part of the country’s goal of becoming self-sufficient.

                                Tightening import norms, India will check all power equipment bought from China for malware and Trojan horses that can be potentially used to trigger electricity grid failures to cripple economic activity in the country, Power Minister R. K. Singh said.

                                India has in the recent days taken steps to impose stringent quality control measures and higher tariffs on goods from China as it looks to boost domestic manufacturing to cut reliance on imports.

                                In an interview to PTI, Mr. Singh said his renewable energy ministry has proposed imposing customs duties on some solar power equipment starting August 1 as part of the country’s goal of becoming self-sufficient",
                    ImageTitle = "RK Singh",
                    ImageUrl = "https://www.thehindu.com/news/national/other-states/12hryi/article29453067.ece/ALTERNATES/FREE_960/RKSINGH-THNAR",
                    IsHighPriority = true,
                    Title = " India to check power equipment from China for malware: R. K. Singh "
                },
                new NewsContentEntity
                {
                    Category = "Business",
                    Description = @" Thailand’s low-cost carrier NokScoot, which is partly owned by Singapore Airlines, said its board of directors decided to liquidate the company as the coronavirus pandemic dimmed prospects for its recovery.

                            The airline, a joint venture between Singapore-based Scoot and Nok Airlines Plc., has not recorded a full-year profit since its inception in 2014.

                            Unprecedented challenges arising from the COVID-19 pandemic have further exacerbated the situation, the company said in a statement.",
                    ImageTitle = "alternates free nockshot",
                    ImageUrl = "https://www.thehindu.com/business/y3mwbf/article31929831.ece/ALTERNATES/FREE_960/nokscoot",
                    IsHighPriority = true,
                    Title = "Thailand’s low-cost airline NokScoot shuts down amid losses "
                },
                new NewsContentEntity
                {
                    Category = "Business",
                    Description = @"ndustry depends heavily on Chinese supplies; executives say being more self-reliant will take time

                            Days after a border clash with China this month in which 20 Indian soldiers were killed, New Delhi told firms to find ways to cut imports from China. But two big industries, automobiles and pharmaceuticals, say this is easier said than done.

                            Like many countries, India relies on China for products such as electronic components and drug ingredients because it cannot make them or source them elsewhere as cheaply, company and industry figures say.Thus, any moves to curb imports or make them costlier without developing alternatives will hurt local businesses.

                            “We don’t import because we like to, but because we have no choice,” said R.C.Bhargava, chairman of Maruti Suzuki India Ltd., the country’s biggest carmaker.",
                     ImageTitle = "Cor  ona head, dfsdfsd",
                    ImageUrl = "",
                    IsHighPriority = true,
                    Title = " Auto, pharma unready to wean off China "
                },
                new NewsContentEntity
                {
                    Category = "Politics",
                    Description = @"Prime Minister K.P. Sharma Oli of Nepal on Sunday said meetings are being organised in India to topple his government.

                        Addressing a gathering at his official residence in memory of the late communist leader Madan Bhandari, Mr. Oli said his government enjoys parliamentary majority and the ouster plans will fail.

                        “There is news coming from Delhi about this. Look at the meetings being organised in India against Nepal’s decision to amend the Constitution to place the revised map of Nepal in the national emblem,” said Prime Minister Oli, pointing at the alleged plot to overthrow his government.
                        ",
                    ImageTitle = "KK OLI",
                    ImageUrl = "",
                    IsHighPriority = true,
                    Title = " Meetings in India to topple my govt., says Nepal PM K.P. Oli "
                },
                new NewsContentEntity
                {
                    Category = "Science",
                    Description = "NASA is preparing for return to the Moon and innumerable activities to equip, shelter, and otherwise support future astronauts are underway. With this, the US space agency has thrown open a challenge to win over Rs 26 lakh, calling the global community to send novel design concepts for compact toilets that can operate in both microgravity and lunar gravity. The astronauts will be eating and drinking, and subsequently urinating and defecating in microgravity and lunar gravity",
                    ImageTitle = "Cor  ona head, dfsdfsd",
                    ImageUrl = "",
                    IsHighPriority = false,
                    Title = " NASA throws open a challenge to win over Rs 26 lakh - Check all details here "
                },
                new NewsContentEntity
                {
                    Category = "Politics",
                    Description = "Amid the surge in coronavirus cases and increased tensions with China, Home Minister Amit Shah on Sunday exuded confidence that the country would overcome the two jung (battle) under the leadership of Prime Minister Narendra Modi. Let me make it clear. Under PM Modi’s leadership, India is going to win both the battles he told ANI.In interview with the news agency, the The Union Minister was also asked about the presence of Chinese troops in the Indian territory. Stressing that it was not the appropriate time to comment, Shah added briefings were going on and if the need arose, I would answer",
                    ImageTitle = " Amit Shah on Sunday exuded",
                    ImageUrl = "https://images.indianexpress.com/2020/06/amit-shah-2.jpg",
                    IsHighPriority = true,
                    Title = "India will win both battles — Covid-19 and China border — under PM Modi’s leadership: Amit Shah"

                },
            };


            return newsContentEnitityList;
        }
    }
}
