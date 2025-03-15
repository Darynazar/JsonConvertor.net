using Json.Models.NodeJson;
using Json.Models.SchemaJson;
using Json.Models.NodeJson;
using Json.Models.SchemaJson;

namespace Json.Services
{
    public class JsonTransformerService
    {
        public SchemaJson Transform(NodeJson nodeJson)
        {
            var schemaJson = new SchemaJson
            {
                Standings = new List<StandingSchema>()
            };

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
                            Name = "England",
                            Slug = "england",
                            Sport = new Sport
                            {
                                Name = "Football",
                                Slug = "football",
                                Id = 1
                            },
                            Flag = "england",
                            Alpha2 = "EN",
                            FieldTranslations = new FieldTranslations
                            {
                                NameTranslation = new NameTranslation
                                {
                                    Ar = "إنجلترا",
                                    Hi = "इंग्लैंड",
                                    Bn = "ইংল্যান্ড"
                                },
                                ShortNameTranslation = new object()
                            }
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
                                Name = "England",
                                Slug = "england",
                                Sport = new Sport
                                {
                                    Name = "Football",
                                    Slug = "football",
                                    Id = 1
                                },
                                Flag = "england",
                                Alpha2 = "EN",
                                FieldTranslations = new FieldTranslations
                                {
                                    NameTranslation = new NameTranslation
                                    {
                                        Ar = "إنجلترا",
                                        Hi = "इंग्लैंड",
                                        Bn = "ইংল্যান্ড"
                                    },
                                    ShortNameTranslation = new object()
                                }
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
                            }
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
                        }
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
                    UpdatedAtTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
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
                                Alpha2 = "EN",
                                Alpha3 = "ENG",
                                Name = "England",
                                Slug = "england"
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
                            }
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
                        ScoreDiffFormatted = $"+{row.Ratio}"
                    };

                    standingSchema.Rows.Add(rowSchema);
                }

                schemaJson.Standings.Add(standingSchema);
            }

            return schemaJson;
        }
    }
}