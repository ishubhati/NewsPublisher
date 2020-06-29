using NewsPublisher.Core.Entities;
using NewsPublisher.Core.Interfaces;
using System.Collections.Generic;

namespace NewsPublisher.Infrastructure.SourceServices
{
    public class InternalSourceProvider : INewsSourceProvider
    {
        public List<NewsContentEntity> GetNewsContents()
        {
            var newsContentEnitityList = new List<NewsContentEntity>
            {
                new NewsContentEntity
                {
                    Category = "Politics",
                    Description = "Now that Trump is back on the road again there's a deluge of fresh material for the late night hosts to tear into — and recent footage of the president signing his precious border wall proved quite the jumping off point for James Corden on Wednesday's Late La",
                    ImageTitle = "Trump is back",
                    ImageUrl = "https://mondrian.mashable.com/2020%252F06%252F25%252F3d%252F8d66aec0503641cdbb9bd9c840aa2c2a.b5c2a.png%252F1200x630.png?signature=wdKD6PEcZCA_4AQ6XXIjiukXHZo=",
                    IsHighPriority = true,
                    Title = "James Corden mocks Trump's border wall signature and latest nonsense rally speech"
                },
                new NewsContentEntity
                {
                    Category = "Politics",
                    Description = "Brian Miller would have one of the toughest jobs in Washington even without the cutthroat politics all around him. As America’s inspector general for pandemic relief, he’s charged with rooting out fraud in the spending of trillions of dollars in emergency aid.",
                    ImageTitle = "andemic aid watchdog steps",
                    ImageUrl = "https://s3.reutersmedia.net/resources/r/?m=02&d=20200626&t=2&i=1523729120&w=1200&r=LYNXMPEG5P0XJ",
                    IsHighPriority = true,
                    Title = "Pandemic aid watchdog steps into partisan war over bailouts - Reuters"
                },
                new NewsContentEntity
                {
                    Category = "Health",
                    Description = "Despite the personal risk, their voices were heard by fellow citizens and politicians alike, as demonstrators sparked a protest movement unlike any in modern history. And it all may have been for nothing.",
                    ImageTitle = "fellow citizens and politicians",
                    ImageUrl = "https://cdn.cnn.com/cnnnext/dam/assets/200627114313-01-floyd-protest-anaheim-0601-super-tease.jpg",
                    IsHighPriority = true,
                    Title = "After weeks of protests, meaningful police reform appears unlikely"
                },
                new NewsContentEntity
                {
                    Category = "Health",
                    Description = "One of the few bright spots of the past few months of quarantine has been Josh Gad’s “Reunited Apart” YouTube series. Every few weeks, he hosts a virtual reunion with the stars and other members of the production team from some of the most beloved movies of t…",
                    ImageTitle = "Progressive Center",
                    ImageUrl = "https://i.kinja-img.com/gawker-media/image/upload/c_fill,f_auto,fl_progressive,g_center,h_675,pg_1,q_80,w_1200/xtwzxrc7ktpy9k6ezio2.jpg",
                    IsHighPriority = true,
                    Title = "How to Watch the 'Ferris Bueller's Day Off' Reunion"
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
                new NewsContentEntity
                {
                    Category = "Science",
                    Description = "NASA is preparing for return to the Moon and innumerable activities to equip, shelter, and otherwise support future astronauts are underway. With this, the US space agency has thrown open a challenge to win over Rs 26 lakh, calling the global community to send novel design concepts for compact toilets that can operate in both microgravity and lunar gravity. The astronauts will be eating and drinking, and subsequently urinating and defecating in microgravity and lunar gravity",
                    ImageTitle = "Cor  ona head, dfsdfsd",
                    ImageUrl = "",
                    IsHighPriority = false,
                    Title = " NASA throws open a challenge to win over Rs 26 lakh - Check all details here "
                },
            };


            return newsContentEnitityList;
        }
    }
}
