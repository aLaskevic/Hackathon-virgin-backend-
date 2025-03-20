
using WebApplication3.Models;

namespace WebApplication3.Repository;

public class ProjectRepository
{
    public List<Project> Projects { get; set; }

    public ProjectRepository()
    {
        SeedData();
    }

    public List<Project> GetProjects()
    {
        return Projects;
    }

    public Reward GetReward(string code)
    {
        foreach (var project1 in Projects)
        {
            var call = (project1.CallToActions.Where(c=>c.QrCode == code).FirstOrDefault());
            if (call != null)
            {
                return call.Reward;
            }
        }

        return null;
    }
    
    public bool AddProjects(Project project)
    {
        Projects.Add(project);
        return true;
    }
    
    private void SeedData()
    {

        Projects = new List<Project>();
        
        int projectId = 1;

        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Atlantic",
            Initiative = "Youngest, Cleanest Fleet in the Sky",
            Challenge =
                "The time for action against climate change is now. Virgin Atlantic are on a mission to achieve net-zero by 2050.",
            WhatVirginIsDoing =
                "Virgin Atlantic is working to accelerate the development of sustainable fuels. On November 28th, we made history with Flight100— becoming the first commercial airline to fly across the Atlantic on 100% SAF - marking a key milestone on the path to decarbonising aviation.",
            CallToActions = new List<CallToAction>{new("Donate", "cleanfleet")},
            Links = new List<string>
            {
                "https://corporate.virginatlantic.com/gb/en/business-for-good/planet.html",
                "https://corporate.virginatlantic.com/gb/en/business-for-good/planet/fuel/flight100.html\nhttps://corporate.virginatlantic.com/gb/en/business-for-good/planet/fuel.html"
            },
            PublishDate = DateTime.Now,
            ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/M_s_galaxy.jpg/640px-M_s_galaxy.jpg"
        });




        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Atlantic & Virgin Unite",
            Initiative = "Protecting our Planet",
            Challenge =
                "Contrails, aircraft condensation trails, heighten the effect of global warming, which may account for more than half (57%) of the entire climate impact of aviation.",
            WhatVirginIsDoing =
                "Virgin Atlantic, Virgin Unite, and Flight100 have also joined forces with RMI to establish the Contrail Impact Task Force, aiming to address the environmental impact of aircraft contrails.",
            CallToActions = new List<CallToAction>{new("Stay informed"), new CallToAction("Donate To RMI")},
            Links = new List<string>
            {
                "https://corporate.virginatlantic.com/gb/en/business-for-good/planet/fleet.html",
                "https://www.virgin.com/virgin-unite/latest/flight100-virgin-atlantic-and-rmi-test-new-ways-to-reduce-aviations-climate"
            },
            PublishDate = DateTime.Now,
            ImageLink = "https://www.science.org/do/10.5555/article.2375495/full/sf-chemtrails-1644894851440.jpg",
            
        });
        

        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Voyages",
            Initiative = "Epic Sea Change For All",
            Challenge =
                "Wildlife havens, carbon stores, storm defences, ocean purifiers – mangrove swamps are one of the hardest-working habitats on Earth, but they’re disappearing fast.",
            WhatVirginIsDoing =
                "Virgin Voyages have teamed up with Virgin’s Foundation, Virgin Unite, to support mangrove forest projects in the Caribbean. The aim is to accelerate nature-based solutions to climate change, and create a scalable model for other regions in the world.",
            CallToActions = new List<CallToAction>(){new CallToAction("Get involved in a Beach Clean onboard"), new CallToAction("Donate to Sea Change For all Fund")},
            Links = new List<string> { "https://www.virginvoyages.com/sustainability" },
            PublishDate = DateTime.Now,
            ImageLink = "https://www.sailingeurope.com/blog/wp-content/uploads/2019/01/Barbados.jpg",

        });
        

        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Media 02",
            Initiative = "Better Connections Plan",
            Challenge =
                "Old IT equipment can lead to electronic waste, or e-waste, polluting the environment. Recycling old IT equipment plays a vital role in preventing this. Virgin Media O2 have a zero landfill policy and will be come a zero-waste business by the end of 2025, and are committed to achieving zero waste operations and products.",
            WhatVirginIsDoing =
                "O2 Recycle is a service launched in October 2009, which allows anyone in the UK whether an O2 customer or not, to trade in their devices and gadgets responsibly, in return for cash. The vast majority of phones we receive will be reused, repaired or recycled for parts. Since launch, the scheme has paid out more than £320 million, and sustainably recycled 3.8 million devices – with zero going to landfill.",
            CallToActions = new List<CallToAction>(){new CallToAction("Sell your old device with O2 Recycle"), new CallToAction("Donate devices via Community Calling")},
            Links = new List<string>
            {
                "https://www.virgin.com/about-virgin/latest/virgin-media-o2-launches-better-connections-plan",
                "https://www.o2recycle.co.uk/"
            },
            PublishDate = DateTime.Now,
            ImageLink = "https://www.hightechrecyclingmi.com/wp-content/uploads/sites/124/2019/10/printer-hero-680x266.jpg",


        });



Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Media 02",
            Initiative = "Better Connections Plan",
            Challenge =
                "Mobile phones can have a significant environmental impact in their production and disposal. The mass production of smartphones not only contributes to environmental pollution but also results in a substantial carbon footprint.",
            WhatVirginIsDoing =
                "Virgin Media O2 is one of 5 of Europe’s leading mobile operators to have joined forces to update and launch a new pan-industry Eco Rating labelling scheme that will help consumers identify and compare the most sustainable mobile phones and encourage suppliers to reduce the environmental impact of their devices.",
            CallToActions = new List<CallToAction>(){new CallToAction("Use the Eco Rating Scheme")},
            Links = new List<string>
            {
                "https://news.virginmediao2.co.uk/archive/new-pan-industry-eco-rating-scheme-launched-for-mobile-phones/",
                "https://www.o2.co.uk/inspiration/the-drop/eco-rating-for-mobile-phones"
            },
            PublishDate = DateTime.Now,
            ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/VoLTE_iPhone.jpg/800px-VoLTE_iPhone.jpg",
        });

/*

        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Media 02",
            Initiative = "Better Connections Plan",
            Challenge =
                "Mobile phones can have a significant environmental impact in their production and disposal. The mass production of smartphones not only contributes to environmental pollution but also results in a substantial carbon footprint.",
            WhatVirginIsDoing =
                "Virgin Media O2 offer a range of like-new second hand smart phones and tablets to help reduce your carbon footprint.",
            CallToActions = "- Buy a like-new second hand smartphone or tablet",
            Links = new List<string> { "https://www.o2.co.uk/shop/like-new" }
        });

        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Limited Edition (VLE) & Virgin Unite",
            Initiative = "Pride 'n Purpose",
            Challenge =
                "Many communities surrounding Ulusaba lack basic needs such as access to clean drinking water, basic healthcare, food, childcare, and job opportunities.",
            WhatVirginIsDoing =
                "Pride 'n Purpose is a non-for-profit organisation, committed to helping disadvantaged communities living adjacent to the Sabi Sand Reserve. The Pride ‘n Purpose philosophy is that people are most effectively helped if they are empowered to help themselves, with this in mind the organisation’s work focuses primarily on sustainable initiatives and it is estimated that Pride ‘n Purpose benefits over 35,000 people across six communities.",
            CallToActions =
                "- Volunteer during your visit to Ulusaba\n- Pack for a Purpose: Donate clothing and household supplies\n- Make a donation",
            Links = new List<string>
            {
                "https://www.virginlimitededition.com/ulusaba/the-reserve/our-commitment/",
                "https://www.packforapurpose.org/destinations/africa/south-africa/ulusaba-private-game-reserve/"
            }
        });

        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Limited Edition (VLE) & Virgin Unite",
            Initiative = "Mahali Mzuri: Inua Jamii",
            Challenge =
                "A key conservation goal around Mahali Mzuri is to aid conservation and preserve the under-threat route of the Great Wildebeest Migration. We also aim to support and enhance the standard of living in local communities.",
            WhatVirginIsDoing =
                "Inua Jamii is Mahali Mzuri’s charitable arm, committed to working with and supporting the local Maasai communities in the Olare Motorogi Conservancy to improve their standards of living. The name 'Inua Jamii' means ‘uplifting the local community’ in Swahili. Our philosophy is that people are most effectively helped if they are empowered to help themselves. Our aim is to nurture communities that thrive through our involvement, simultaneously fostering self-reliance and establishing sustainable resources for generations to come.",
            CallToActions =
                "- Volunteer during your visit to Mahali Mzuri\n- Visit the community or the Maa Trust\n- Pack for a Purpose: Donate clothing and household supplies\n- Make a donation",
            Links = new List<string>
            {
                "https://www.virginlimitededition.com/mahali-mzuri/the-camp/our-commitment/",
                "https://www.virginlimitededition.com/media/dvvi4c4q/mahali-mzuri-inua-jamii-brochure-oct-24.pdf"
            }
        });

        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Unite",
            Initiative = "Planetary Guardians",
            Challenge =
                "The planetary boundaries framework is a key framework for grasping and addressing our footprint on Earth and identifies nine critical systems needed to regulate the health of the entire planet. From climate change to freshwater use, biodiversity loss to chemical pollution and the release of novel entities, these boundaries define the 'safe operating space' for humanity. We currently face an onslaught of environmental and social dilemmas.",
            WhatVirginIsDoing =
                "The new assessment of the Planetary Boundaries was so stark it compelled Virgin Unite to work with the Potsdam Institute to convene a group of leaders and activists to become ‘Planetary Guardians', with an aim to “elevate the science, catalyse systems change to safeguard the global commons, and spark a movement to tackle the biggest crisis we have ever faced.",
            CallToActions = "- Watch the video to learn more about our nine planetary boundaries",
            Links = new List<string>
            {
                "https://www.youtube.com/watch?v=d4fdF8rq5h8",
                "https://www.virgin.com/branson-family/richard-branson-blog/how-the-planetary-guardians-can-help-secure-earths-future",
                "https://unite.virgin.com/our-work/planetary-guardians/index.html?region=gb"
            }
        });
        
        Projects.Add(new Project()
        {
            Id = projectId++,
            VirginCompany = "Virgin Unite",
            Initiative = "The Elders",
            Challenge =
                "The world is rapidly changing, and is facing challenges in leadership, peace-building, inequality, exclusion and injustice.",
            WhatVirginIsDoing =
                "The Elders were incubated by Virgin Unite and launched by Nelson Mandela in 2007 to create an independent global leaders working together for peace, justice, human rights and a sustainable plane. Their work has been truly world changing. They have written an open letter to call on world leaders to address the world's existential threats more decisively.",
            CallToActions = "- Sign their open letter calling for long view leadership on existential threats.",
            Links = new List<string>
            {
                "https://theelders.org/news/elders-and-future-life-institute-release-open-letter-calling-long-view-leadership-existential",
                "https://futureoflife.org/open-letter/long-view-leadership-on-existential-threats/"
            }
        });

        Projects.Add(new Project()
        {
            VirginCompany = "Virgin Unite",
            Initiative = "Ocean Unite / ORRAA",
            Challenge =
                "The dual crises of climate change and mass wildlife extinctions threaten to forever change our world. By 2050, over 570 low-lying coastal cities will face threats from sea level rise and an estimated 800 million people will be at risk to storm surge and flooding from extreme weather events. The currents that swirl around Antarctica transport essential nutrients to other ocean currents that feed the rest of the world’s ocean. This vitally important region is on the frontline of the climate crisis.",
            WhatVirginIsDoing =
                "In October 2016, Ocean Unite / ORRAA in collaboration with the Marine Conservation Institute and Oceans 5, brought together 30 of the largest NGOs from around the world, stimulating joint efforts towards the goal of strongly protecting at least 30% of the Ocean by 2030. A current campaign is to secure the largest act of Ocean Protection in history by protecting Antarctica's waters.",
            CallToActions =
                "- Add your name to the petition urging leaders from CCAMLR member countries to act now to protect Antarctica's waters #CallOnCCAMLR",
            Links = new List<string>
            {
                "https://only.one/act/antarctica",
                "https://www.virgin.com/virgin-unite/latest/securing-the-largest-act-of-ocean-protection-in-history"
            }
        });

        Projects.Add(new Project()
        {
            VirginCompany = "Virgin Unite",
            Initiative = "Community Mapathon: Humanitarian OpenStreetMap (HOT)",
            Challenge =
                "Every day, millions of people worldwide face life-threatening crises. Humanitarian aid is a vital lifeline that delivers a variety of essential services to those in need. But as global crises escalate, so does the need for support. We cannot ignore the rise in global humanitarian needs.",
            WhatVirginIsDoing =
                "The Humanitarian OpenStreetMap Team (HOT) is a community mapping organisation supporting humanitarian responses to nearly 100 crises; many caused by the impacts of Climate Change. Funded by one of Virgin Unite's co-funded initiative's Audacious, HOT specialises in humanitarian action and community development through open mapping, mapping areas for one billion people vulnerable to disasters in 94 countries. This covers a range of things – from supporting disaster relief efforts, to helping to inform action to combat the effects of climate change.",
            CallToActions = "- Spare some time to join the mappers and help with mapping",
            Links = new List<string>
            {
                "https://www.virgin.com/virgin-unite/latest/join-humanitarian-openstreetmap-team-to-help-map-el-nino-2023",
                "https://www.hotosm.org/updates/mapping-for-el-nino-2023-early-warning-and-anticipatory-action/"
            }
        });
        
        Projects.Add(new Project()
        {
            VirginCompany = "Virgin Unite",
            Initiative = "Project CETI (Cetacean Translation Initiative)",
            Challenge =
                "Humanity is facing the collapse of entire ecosystems, and the biodiversity of our planet is being eroded at unprecedented rates. It is a pivotal time for us to reshape how we co-exist in and with nature. Whales play a significant role in our environment’s health and understanding of marine mammals. They also support growing economies relying on whale watching and spectator activities by bringing tourism capital.",
            WhatVirginIsDoing =
                "Project CETI is one of Virgin Unite's co-funded Audacious projects. It uses machine learning and robotics to translate sperm whale clicks in Dominica. By shedding light on the intricate and intelligent communication of whales, the project not only aims to accelerate conservation efforts, but has the potential to transform the way we understand our relationship with the natural world.",
            CallToActions = "- Become a whale interpreter\n- Donate to support Project CETI",
            Links = new List<string>
                { "https://www.projectceti.org/get-involved", "https://www.audaciousproject.org/grantees/project-ceti" }
        });

        Projects.Add(new Project()
        {
            VirginCompany = "Virgin Unite",
            Initiative = "Eve Branson Foundation",
            Challenge =
                "The aim of the Eve Branson Foundation is to support local people and communities around the Atlas Mountains. On 8th September 2023, Morocco was hit hard by a strong earthquake measuring magnitude 6.8. Remote communities in the High Atlas Mountains were badly affected.",
            WhatVirginIsDoing =
                "The Eve Branson Foundation is a small non-profit based in Morocco. Their mission is to create opportunities for local people in the High Atlas Mountains which can make a meaningful difference to their families and community. They have developed initiatives in four key areas: artisanal training, environment, healthcare and education.",
            CallToActions = "- Donate\n- Visit\n- Pack for a Purpose\n- Buy EBF products through Virgin Red",
            Links = new List<string>
            {
                "https://evebransonfoundation.org.uk/", "https://evebransonfoundation.org.uk/pack-for-a-purpose/",
                "https://www.virgin.com/virgin-red"
            }
        });

        Projects.Add(new Project()
        {
            VirginCompany = "Virgin Unite",
            Initiative = "Unite BVI",
            Challenge =
                "The BVI faces a number of pressing issues including creating opportunities in the community, improving the quality of education, developing a vibrant entrepreneurial culture and preservation of the natural environment.",
            WhatVirginIsDoing =
                "Since its launch, Unite BVI has brought together people, ideas and resources to help tackle community and environmental challenges. The Unite BVI team collaborate with communities and BVI change-makers to solve the most pressing issues faced by the BVI and its people. Working across a wide range of projects, Unite BVI advocate for the protection of the environment as well as enriching the community through supporting entrepreneurs, investing in education, and addressing public health and social welfare issues with sustainable solutions.",
            CallToActions = "- Join the community",
            Links = new List<string> { "https://unitebvi.com/get-involved/index.html?region=gb" }
        });
*/
    }
}