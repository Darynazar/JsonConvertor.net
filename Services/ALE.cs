using Json.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Json.Services
{
    public class ALE : IConvertor
    {
        public string Run(string jsonInput)
        {
            // Step 1: Deserialize the input JSON string into NodeJson object
            var nodeJson = JsonConvert.DeserializeObject<NodeJson>(jsonInput);

            if (nodeJson == null)
            {
                throw new ArgumentException("Invalid JSON input.");
            }

            // Step 2: Transform the NodeJson object into SchemaJson object
            var schemaJson = Transform(nodeJson);

            // Step 3: Serialize the SchemaJson object into a JSON string
            string outputJson = JsonConvert.SerializeObject(schemaJson, Formatting.Indented);

            return outputJson;
        }

        private SchemaJson Transform(NodeJson nodeJson)
        {
            var schemaJson = new SchemaJson
            {
                Standings = new List<StandingSchema>()
            };

            // Step 1: Extract the country information from the input JSON
            var country = nodeJson.Countries?.FirstOrDefault();
            if (country == null)
            {
                throw new ArgumentException("Country information is missing in the input JSON.");
            }

            // Step 2: Use the extracted country information
            string countryName = country.Name;
            string countrySlug = country.NameForURL;
            string countryFlag = countrySlug; // Assuming the flag is the same as the slug
            string countryAlpha2 = GetAlpha2Code(countryName); // Helper method to get Alpha2 code

            foreach (var standing in nodeJson.Standings)
            {
                var standingSchema = new StandingSchema
                {
                    Tournament = new Tournament
                    {
                        Name = standing.DisplayName,
                        Slug = standing.DisplayName.ToLower().Replace(" ", "-"),
                        Category = new Category
                        {
                            Id = 1,
                            Name = countryName, // Dynamic
                            Slug = countrySlug, // Dynamic
                            Sport = new Sport
                            {
                                Name = "Football",
                                Slug = "football",
                                Id = 1
                            },
                            Flag = countryFlag, // Dynamic
                            Alpha2 = countryAlpha2, // Dynamic
                            FieldTranslations = new FieldTranslations
                            {
                                NameTranslation = new NameTranslation
                                {
                                    Ar = "إنجلترا", // You can make this dynamic too if needed
                                    Hi = "इंग्लैंड",
                                    Bn = "ইংল্যান্ড"
                                },
                                ShortNameTranslation = new object()
                            },
                         
                        },
                        UniqueTournament = new UniqueTournament
                        {
                            Name = standing.DisplayName,
                            Slug = standing.DisplayName.ToLower().Replace(" ", "-"),
                            PrimaryColorHex = "#3c1c5a",
                            SecondaryColorHex = "#f80158",
                            Category = new Category
                            {
                                Id = 1,
                                Name = countryName, // Dynamic
                                Slug = countrySlug, // Dynamic
                                Sport = new Sport
                                {
                                    Name = "Football",
                                    Slug = "football",
                                    Id = 1
                                },
                                Flag = countryFlag, // Dynamic
                                Alpha2 = countryAlpha2, // Dynamic
                                FieldTranslations = new FieldTranslations
                                {
                                    NameTranslation = new NameTranslation
                                    {
                                        Ar = "إنجلترا",
                                        Hi = "इंग्लैंड",
                                        Bn = "ইংল্যান্ড"
                                    },
                                    ShortNameTranslation = new object()
                                },
                         
                            },
                            UserCount = 1328140,
                            HasPerformanceGraphFeature = true,
                            Id = 17,
                            Country = new Country(),
                            DisplayInverseHomeAwayTeams = false,
                            FieldTranslations = new FieldTranslations
                            {
                                NameTranslation = new NameTranslation
                                {
                                    Ar = "الدوري الإنجليزي الممتاز",
                                    Hi = "प्रिमियर लीग",
                                    Bn = "প্রিমিয়ার লিগ"
                                },
                                ShortNameTranslation = new object()
                            },
                        
                        },
                        Priority = 618,
                        IsGroup = false,
                        IsLive = false,
                        Id = 1,
                        FieldTranslations = new FieldTranslations
                        {
                            NameTranslation = new NameTranslation
                            {
                                Ar = "الدوري الإنجليزي الممتاز",
                                Hi = "प्रिमियर लीग",
                                Bn = "প্রিমিয়ার লিগ"
                            },
                            ShortNameTranslation = new object()
                        },
               
                    },
                    Name = standing.DisplayName,
                    Type = "total",
                    Descriptions = new List<object>(),
                    TieBreakingRule = new TieBreakingRule
                    {
                        Text = "In the event that two (or more) teams have an equal number of points, the following rules break the tie: 1. Goal difference 2. Goals scored 3. H2H",
                        Id = 2393
                    },
                    Rows = new List<RowSchema>(),
                    Id = 126654,
                    UpdatedAtTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                
                };

                foreach (var row in standing.Rows)
                {
                    var rowSchema = new RowSchema
                    {
                        Team = new Team
                        {
                            Name = row.Competitor.Name,
                            Slug = row.Competitor.NameForURL,
                            ShortName = row.Competitor.Name,
                            Gender = "M",
                            Sport = new Sport
                            {
                                Name = "Football",
                                Slug = "football",
                                Id = 1
                            },
                            UserCount = 2749196,
                            NameCode = row.Competitor.SymbolicName,
                            Disabled = false,
                            National = false,
                            Type = 0,
                            Id = row.Competitor.Id,
                            Country = new Country
                            {
                                Alpha2 = countryAlpha2, // Dynamic
                                Alpha3 = GetAlpha3Code(countryName), // Dynamic
                                Name = countryName, // Dynamic
                                Slug = countrySlug // Dynamic
                            },
                            EntityType = "team",
                            TeamColors = new TeamColors
                            {
                                Primary = row.Competitor.Color,
                                Secondary = row.Competitor.AwayColor,
                                Text = "#ffffff"
                            },
                            FieldTranslations = new FieldTranslations
                            {
                                NameTranslation = new NameTranslation
                                {
                                    Ar = "ليفربول",
                                    Ru = "Ливерпуль",
                                    Hi = "लिवरपूल",
                                    Bn = "লিভারপুল"
                                },
                                ShortNameTranslation = new NameTranslation
                                {
                                    Ar = "ليفربول",
                                    Hi = "लिवरपूल",
                                    Bn = "লিভারপুল"
                                }
                            },
                       
                        },
                        Descriptions = new List<object>(),
                        Promotion = new Promotion
                        {
                            Text = "Champions League",
                            Id = 804
                        },
                        Position = row.Position,
                        Matches = row.GamePlayed,
                        Wins = row.GamesWon,
                        ScoresFor = row.For,
                        ScoresAgainst = row.Against,
                        Id = row.Competitor.Id,
                        Losses = row.GamesLost,
                        Draws = row.GamesEven,
                        Points = (int)row.Points,
                        ScoreDiffFormatted = $"+{row.Ratio}",
                   
                    };

                    standingSchema.Rows.Add(rowSchema);
                }

                schemaJson.Standings.Add(standingSchema);
            }

            return schemaJson;
        }

        private string GetAlpha2Code(string countryName)
        {
            // Add your logic to map country names to Alpha2 codes
            switch (countryName.ToLower())
            {
                case "england":
                    return "EN";
                case "belgium":
                    return "BE";
                // Add more cases as needed
                default:
                    return "XX"; // Default value
            }
        }

        private string GetAlpha3Code(string countryName)
        {
            // Add your logic to map country names to Alpha3 codes
            switch (countryName.ToLower())
            {
                case "england":
                    return "ENG";
                case "belgium":
                    return "BEL";
                // Add more cases as needed
                default:
                    return "XXX"; // Default value
            }
        }

        #region Model
        public class NodeJson
        {
            public long LastUpdateId { get; set; }
            public long RequestedUpdateId { get; set; }
            public int Ttl { get; set; }
            public List<Standing> Standings { get; set; }
            public List<Sport> Sports { get; set; }
            public List<Country> Countries { get; set; }
            public List<Competition> Competitions { get; set; }
            public List<object> Bookmakers { get; set; }
        }

        public class Standing
        {
            public int CompetitionId { get; set; }
            public int SeasonNum { get; set; }
            public int StageNum { get; set; }
            public bool IsCurrentStage { get; set; }
            public string DisplayName { get; set; }
            public int CurrentGroupCategory { get; set; }
            public List<Header> Headers { get; set; }
            public List<Row> Rows { get; set; }
            public List<Destination> Destinations { get; set; }
            public List<FilterType> FilterTypes { get; set; }
        }

        public class Header
        {
            public string Key { get; set; }
            public string Name { get; set; }
            public bool IsMajor { get; set; }
        }

        public class Row
        {
            public Competitor Competitor { get; set; }
            public int GamePlayed { get; set; }
            public int GamesWon { get; set; }
            public int GamesLost { get; set; }
            public int GamesEven { get; set; }
            public int For { get; set; }
            public int Against { get; set; }
            public double Ratio { get; set; }
            public double Points { get; set; }
            public int Strike { get; set; }
            public int GamesOT { get; set; }
            public int GamesWonOnOT { get; set; }
            public int GamesWonOnPen { get; set; }
            public int GamesLossOnOT { get; set; }
            public int GamesLossOnPen { get; set; }
            public string Pct { get; set; }
            public int Position { get; set; }
            public int Trend { get; set; }
            public List<DetailedRecentForm> DetailedRecentForm { get; set; }
            public NextMatch NextMatch { get; set; }
            public List<int> RecentForm { get; set; }
            public int DestinationNum { get; set; }
            public double Ppg { get; set; }
            public double Oppg { get; set; }
        }

        public class Competitor
        {
            public int Id { get; set; }
            public int CountryId { get; set; }
            public int SportId { get; set; }
            public string Name { get; set; }
            public string SymbolicName { get; set; }
            public string NameForURL { get; set; }
            public int Type { get; set; }
            public int PopularityRank { get; set; }
            public int ImageVersion { get; set; }
            public string Color { get; set; }
            public string AwayColor { get; set; }
            public int MainCompetitionId { get; set; }
            public bool HasSquad { get; set; }
            public bool HasTransfers { get; set; }
            public int CompetitorNum { get; set; }
            public bool HideOnSearch { get; set; }
            public bool HideOnCatalog { get; set; }
        }

        public class DetailedRecentForm
        {
            public int Id { get; set; }
            public int SportId { get; set; }
            public int CompetitionId { get; set; }
            public int SeasonNum { get; set; }
            public int StageNum { get; set; }
            public int RoundNum { get; set; }
            public string RoundName { get; set; }
            public string CompetitionDisplayName { get; set; }
            public DateTime StartTime { get; set; }
            public int StatusGroup { get; set; }
            public string StatusText { get; set; }
            public string ShortStatusText { get; set; }
            public int GameTimeAndStatusDisplayType { get; set; }
            public Competitor HomeCompetitor { get; set; }
            public Competitor AwayCompetitor { get; set; }
            public int Outcome { get; set; }
            public int Winner { get; set; }
            public List<double> Scores { get; set; }
            public int HomeAwayTeamOrder { get; set; }
            public bool HasPointByPoint { get; set; }
        }

        public class NextMatch
        {
            public int Id { get; set; }
            public int SportId { get; set; }
            public int CompetitionId { get; set; }
            public int SeasonNum { get; set; }
            public int StageNum { get; set; }
            public int RoundNum { get; set; }
            public string RoundName { get; set; }
            public string CompetitionDisplayName { get; set; }
            public DateTime StartTime { get; set; }
            public int StatusGroup { get; set; }
            public string StatusText { get; set; }
            public string ShortStatusText { get; set; }
            public int GameTimeAndStatusDisplayType { get; set; }
            public bool JustEnded { get; set; }
            public double GameTime { get; set; }
            public string GameTimeDisplay { get; set; }
            public bool HasTVNetworks { get; set; }
            public Competitor HomeCompetitor { get; set; }
            public Competitor AwayCompetitor { get; set; }
            public bool IsHomeAwayInverted { get; set; }
            public bool HasStandings { get; set; }
            public string StandingsName { get; set; }
            public bool HasBrackets { get; set; }
            public bool HasPreviousMeetings { get; set; }
            public bool HasRecentMatches { get; set; }
            public int Winner { get; set; }
            public int HomeAwayTeamOrder { get; set; }
            public bool HasPointByPoint { get; set; }
        }

        public class Destination
        {
            public int Num { get; set; }
            public string Name { get; set; }
            public string GuaranteedText { get; set; }
            public string Color { get; set; }
            public int Type { get; set; }
        }

        public class FilterType
        {
            public int Type { get; set; }
            public string Name { get; set; }
        }

        public class Sport
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string NameForURL { get; set; }
            public bool DrawSupport { get; set; }
            public int ImageVersion { get; set; }
            public string Slug { get; set; } // Added
        }

        public class Country
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string NameForURL { get; set; }
            public List<int> SportTypes { get; set; }
            public int ImageVersion { get; set; }
            public bool IsInternational { get; set; }
            public string Alpha2 { get; set; } // Added
            public string Alpha3 { get; set; } // Added
            public string Slug { get; set; }   // Added
        }

        public class Competition
        {
            public int Id { get; set; }
            public int CountryId { get; set; }
            public int SportId { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public bool HasStandings { get; set; }
            public bool HasLiveStandings { get; set; }
            public bool HasStandingsGroups { get; set; }
            public bool HasBrackets { get; set; }
            public string NameForURL { get; set; }
            public int PopularityRank { get; set; }
            public int ImageVersion { get; set; }
            public int CurrentStageType { get; set; }
            public string Color { get; set; }
            public int CompetitorsType { get; set; }
            public int CurrentPhaseNum { get; set; }
            public List<Season> Seasons { get; set; }
            public int CurrentSeasonNum { get; set; }
            public int CurrentStageNum { get; set; }
            public bool HideOnCatalog { get; set; }
            public bool HideOnSearch { get; set; }
            public bool IsInternational { get; set; }
        }

        public class Season
        {
            public int Num { get; set; }
            public string Name { get; set; }
            public bool UseName { get; set; }
            public int CompetitionId { get; set; }
            public bool HasStandings { get; set; }
            public List<Stage> Stages { get; set; }
        }

        public class Stage
        {
            public int Num { get; set; }
            public string Name { get; set; }
            public bool UseName { get; set; }
            public bool HasStandings { get; set; }
            public bool IsFinal { get; set; }
            public int StageType { get; set; }
        }

        public class SchemaJson
        {
            public List<StandingSchema> Standings { get; set; }
        }

        public class StandingSchema
        {
            public Tournament Tournament { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public List<object> Descriptions { get; set; }
            public TieBreakingRule TieBreakingRule { get; set; }
            public List<RowSchema> Rows { get; set; }
            public int Id { get; set; }
            public long UpdatedAtTimestamp { get; set; }
        }

        public class Tournament
        {
            public string Name { get; set; }
            public string Slug { get; set; }
            public Category Category { get; set; }
            public UniqueTournament UniqueTournament { get; set; }
            public int Priority { get; set; }
            public bool IsGroup { get; set; }
            public bool IsLive { get; set; }
            public int Id { get; set; }
            public FieldTranslations FieldTranslations { get; set; }
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Slug { get; set; }
            public Sport Sport { get; set; }
            public string Flag { get; set; }
            public string Alpha2 { get; set; }
            public FieldTranslations FieldTranslations { get; set; }
        }

        public class UniqueTournament
        {
            public string Name { get; set; }
            public string Slug { get; set; }
            public string PrimaryColorHex { get; set; }
            public string SecondaryColorHex { get; set; }
            public Category Category { get; set; }
            public int UserCount { get; set; }
            public bool HasPerformanceGraphFeature { get; set; }
            public int Id { get; set; }
            public Country Country { get; set; }
            public bool DisplayInverseHomeAwayTeams { get; set; }
            public FieldTranslations FieldTranslations { get; set; }
        }

        public class FieldTranslations
        {
            public NameTranslation NameTranslation { get; set; }
            public object ShortNameTranslation { get; set; }
        }

        public class NameTranslation
        {
            public string Ar { get; set; }
            public string Hi { get; set; }
            public string Bn { get; set; }
            public string Ru { get; set; } // Added
        }

        public class TieBreakingRule
        {
            public string Text { get; set; }
            public int Id { get; set; }
        }

        public class RowSchema
        {
            public Team Team { get; set; }
            public List<object> Descriptions { get; set; }
            public Promotion Promotion { get; set; }
            public int Position { get; set; }
            public int Matches { get; set; }
            public int Wins { get; set; }
            public int ScoresFor { get; set; }
            public int ScoresAgainst { get; set; }
            public int Id { get; set; }
            public int Losses { get; set; }
            public int Draws { get; set; }
            public int Points { get; set; }
            public string ScoreDiffFormatted { get; set; }
        }

        public class Team
        {
            public string Name { get; set; }
            public string Slug { get; set; }
            public string ShortName { get; set; }
            public string Gender { get; set; }
            public Sport Sport { get; set; }
            public int UserCount { get; set; }
            public string NameCode { get; set; }
            public bool Disabled { get; set; }
            public bool National { get; set; }
            public int Type { get; set; }
            public int Id { get; set; }
            public Country Country { get; set; }
            public string EntityType { get; set; }
            public TeamColors TeamColors { get; set; }
            public FieldTranslations FieldTranslations { get; set; }
        }

        public class TeamColors
        {
            public string Primary { get; set; }
            public string Secondary { get; set; }
            public string Text { get; set; }
        }

        public class Promotion
        {
            public string Text { get; set; }
            public int Id { get; set; }
        }
        #endregion
    }
}