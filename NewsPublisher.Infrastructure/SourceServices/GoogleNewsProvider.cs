using NewsPublisher.Core.Entities;
using NewsPublisher.Core.Interfaces;
using NewsPublisher.Infrastructure.SourceModels.Google;
using System.Collections.Generic;

namespace NewsPublisher.Infrastructure.SourceServices
{
    public class GoogleNewsProvider : INewsSourceProvider
    {
        public List<NewsContentEntity> GetNewsContents()
        {
            var newsContentEnitityList = new List<NewsContentEntity>();

            var googleNewsContents = this.GetContentFromGoogle();

            foreach (var news in googleNewsContents)
            {
                var newsContentEnitity = new NewsContentEntity
                {
                    Category = news.ArticleCategory,
                    Description = news.Description,
                    ImageTitle = news.ImageTitlegoogle,
                    ImageUrl = news.ImageTitlegoogle,
                    IsHighPriority = news.IsBreakingNews,
                    Title = news.Headline
                };
                newsContentEnitityList.Add(newsContentEnitity);
            }

            return newsContentEnitityList;
        }

        #region "Private methods data mocked for google news"
        private List<NewsContentGoogle> GetContentFromGoogle()
        {
            var googlenewsContents = new List<NewsContentGoogle>();

            var newsContentGoogle = new NewsContentGoogle
            {
                ArticleCategory = "Sports",
                Description = @"A selection of Reds supporters have been criticised after gathering in the city to revel in the club's first title win in 30 years
The Mayor of Liverpool,
                Joe Anderson,
                has condemned the behaviour of a selection of supporters that overstepped the mark in celebrating the Reds' first title win in 30 years.

The raucous scenes that have been shared across social media display fans ignoring social - distancing measures as celebrations continued into a second night despite warnings from the city council and the police.

One particularly concerning video shows the Liver Building in the city,
                that houses Everton club offices and had been lit up in blue that evening,
                being directly hit by a firework.",
                Headline = "Jubilant Liverpool fans condemned for wild title celebrations as firework hits building & causes fire",
                ImageCDNUrl = "https://images.daznservices.com/di/library/GOAL/53/eb/liverpool-fan-celebrations-premier-league-title_1mnbl7p30zttu1mlgnscjc5erw.jpg?t=-151660670&amp;quality=60&amp;w=1600",
                ImageTitlegoogle = "Liverpool",
                IsBreakingNews = false
            };

            googlenewsContents.Add(newsContentGoogle);

            var newsContentGoogle1 = new NewsContentGoogle
            {
                ArticleCategory = "Sports",
                Description = @"A selection of Reds supporters have been criticised after gathering in the city to revel in the club's first title win in 30 years
The Mayor of MAN UTD,
                Joe Anderson,
                has condemned the behaviour of a selection of supporters that overstepped the mark in celebrating the Reds' first title win in 30 years.

The raucous scenes that have been shared across social media display fans ignoring social - distancing measures as celebrations continued into a second night despite warnings from the city council and the police.

One particularly concerning video shows the Liver Building in the city,
                that houses Everton club offices and had been lit up in blue that evening,
                being directly hit by a firework.",
                Headline = "Jubilant MAN UTD fans condemned for wild title celebrations as firework hits building & causes fire",
                ImageCDNUrl = "https://images.daznservices.com/di/library/GOAL/53/eb/liverpool-fan-celebrations-premier-league-title_1mnbl7p30zttu1mlgnscjc5erw.jpg?t=-151660670&amp;quality=60&amp;w=1600",
                ImageTitlegoogle = "MAN UTD",
                IsBreakingNews = false
            };

            googlenewsContents.Add(newsContentGoogle1);

            var newsContentGoogle2 = new NewsContentGoogle
            {
                ArticleCategory = "Sports",
                Description = @"A selection of Reds supporters have been criticised after gathering in the city to revel in the club's first title win in 30 years
The Mayor of Pune United,
                Joe Anderson,
                has condemned the behaviour of a selection of supporters that overstepped the mark in celebrating the Reds' first title win in 30 years.

The raucous scenes that have been shared across social media display fans ignoring social - distancing measures as celebrations continued into a second night despite warnings from the city council and the police.

One particularly concerning video shows the Liver Building in the city,
                that houses Everton club offices and had been lit up in blue that evening,
                being directly hit by a firework.",
                Headline = "JubilantPune United fans condemned for wild title celebrations as firework hits building & causes fire",
                ImageCDNUrl = "https://images.daznservices.com/di/library/GOAL/53/eb/liverpool-fan-celebrations-premier-league-title_1mnbl7p30zttu1mlgnscjc5erw.jpg?t=-151660670&amp;quality=60&amp;w=1600",
                ImageTitlegoogle = "Pune United",
                IsBreakingNews = false
            };

            googlenewsContents.Add(newsContentGoogle2);

            var newsContentGoogle3 = new NewsContentGoogle
            {
                ArticleCategory = "Politics",
                Description = @"There was no hike in the prices of petrol and diesel in the metro cities on Sunday, marking a pause after 21 consecutive days of increase, ever since state-owned oil companies returned to the normal practice of daily reviews following a 12-week hiatus. In the national capital, the price of petrol remained unchanged at Saturday's price of Rs 80.38 per litre and diesel was untouched at Rs 80.40 per litre, according to notifications from state-run Indian Oil Corporation, the country's largest fuel retailer. The prices were increased by 25 paise per litre for petrol and 21 paise per litre for diesel in the national capital on Saturday. The prices in the other metros of Chennai, Mumbai and Kolkata remained unchanged as well. ",
                Headline = " Petrol, Diesel Price Hike Paused After 21 Days ",
                ImageCDNUrl = "https://images.daznservices.com/di/library/GOAL/53/eb/liverpool-fan-celebrations-premier-league-title_1mnbl7p30zttu1mlgnscjc5erw.jpg?t=-151660670&amp;quality=60&amp;w=1600",
                ImageTitlegoogle = "Pune United",
                IsBreakingNews = false
            };

            googlenewsContents.Add(newsContentGoogle3);

            var newsContentGoogle4 = new NewsContentGoogle
            {
                ArticleCategory = "Politics",
                Description = @"For the third time since the process to divest national carrier Air India began in January, the government has been again forced to further push the dates because of the COVID-19 disruption.

                        In a notice on June 27, Ministry of Finance announced that the last day to submit expression of interest has been extended to August 31, from June 30.

                        Also, now the government will intimate the 'qualified interested bidders' by September 14, from July 14 earlier.

                        The extension was a foregone conclusion, with some even suggesting the government to pause the divestment process for the moment.",
                Headline = " Coronavirus impact: Deadline to submit bids for Air India extended, for the third time",
                ImageCDNUrl = "https://images.daznservices.com/di/library/GOAL/53/eb/liverpool-fan-celebrations-premier-league-title_1mnbl7p30zttu1mlgnscjc5erw.jpg?t=-151660670&amp;quality=60&amp;w=1600",
                ImageTitlegoogle = "Pune United",
                IsBreakingNews = false
            };

            googlenewsContents.Add(newsContentGoogle4);

            var newsContentGoogle5 = new NewsContentGoogle
            {
                ArticleCategory = "Politics",
                Description = @" Two separate government orders on stocking up of LPG cylinders for two months in the Kashmir valley and on vacating of school buildings for the security forces in Ganderbal, adjoining Kargil, has triggered a fresh wave of anxiety among the locals, in the wake of India-China face-off.

                        Described as a “most urgent matter”, an Adviser to Lt. Governor G.C. Murmu has passed directions in a meeting on June 23, “to ensure sufficient stocks of the LPG in the Valley as the supply gets affected due to closure of the National Highway on account of landslips”.

                        According to an order passed by the Director of the Food, Civil Supplies and Consumers, the oil companies should make adequate stocks of LPG that can last up to two months at bottling plants as well as godowns.",
                Headline = "  Anxiety in Kashmir as govt. orders stocking up of LPG for two months, seeks school buildings for security forces ",
                ImageCDNUrl = "https://www.thehindu.com/news/national/other-states/8k8miw/article31937956.ece/ALTERNATES/FREE_960/PTI28-06-2020000014ATHNAK",
                ImageTitlegoogle = "Pune United",
                IsBreakingNews = false
            };

            googlenewsContents.Add(newsContentGoogle5);

            var newsContentGoogle6 = new NewsContentGoogle
            {
                ArticleCategory = "Sports",
                Description = @" You move that to Optus stadium in Perth or even Adelaide Oval you will get full venues. Adelaide in particular loves seeing the Indians play. The India-Pakistan game in the World Cup sold out in 52 mins or something,” he added.

                    Last month, Western Australia Cricket Association (WACA) chief Christina Matthews had lashed out at Cricket Australia for choosing Brisbane over Perth as one of the venues for the high-profile Test series against India, later this year.

                    Taylor believes WACA will look to seize the opportunity to host Virat-Kohli and his men.

                    “Those venues specially Perth will be trying hard to get that game as it would look better with full crowds.”

                    The Optus stadium can sit 60,000 supporters and is regarded as the best venue in Australia outside the MCG.

                    Earlier this week red-ball skipper Tim Paine had a also expressed fears that the Boxing Day Test could indeed be shifted from Melbourne ",
                ImageCDNUrl = "https://www.thehindu.com/sport/cricket/x3vsow/article31938324.ece/ALTERNATES/FREE_960/MCG",
                ImageTitlegoogle = "Pune United",
                IsBreakingNews = false
            };

            googlenewsContents.Add(newsContentGoogle6);

            return googlenewsContents;
        }
        #endregion
    }
}
