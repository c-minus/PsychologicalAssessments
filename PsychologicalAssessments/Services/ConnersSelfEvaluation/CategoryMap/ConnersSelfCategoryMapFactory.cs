using PsychologicalAssessments.Orchestrator.CategoryMap;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.CategoryMap;

public class ConnersSelfCategoryMapFactory : ICategoryMapFactory
{
    private IEnumerable<Orchestrator.CategoryMap.CategoryMap>? _categories;

    public ConnersSelfCategoryMapFactory()
    {
        CategoryMap();
    }

    public IEnumerable<string> Get(byte id)
    {
        var result = _categories!.FirstOrDefault(c => c.Id == id)?.Categories;

        return result ?? Enumerable.Empty<string>();
    }

    private void CategoryMap()
    {
        _categories = new List<Orchestrator.CategoryMap.CategoryMap>
        {
            new()
            {
                Id = 1,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new()
            {
                Id = 2,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 3,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 4,
                Categories = new List<string>
                {
                    "HY"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 5,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 6,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 7,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 8,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 9,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 10,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 11,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 12,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 13,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 14,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 15,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 16,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 17,
                Categories = new List<string>
                {
                    "IN", "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 18,
                Categories = new List<string>
                {
                    "AG"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 19,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 20,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 21,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 22,
                Categories = new List<string>
                {
                    "AG"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 23,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 24,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 25,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 26,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 27,
                Categories = new List<string>
                {
                    "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 28,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 29,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 30,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 31,
                Categories = new List<string>
                {
                    "IN", "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 32,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 33,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 34,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 35,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 36,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 37,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 38,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 39,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 40,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 41,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 42,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 43,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 44,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 45,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 46,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 47,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 48,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 49,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 50,
                Categories = new List<string>
                {
                    "HY"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 51,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 52,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 53,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 54,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 55,
                Categories = new List<string>
                {
                    "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 56,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 57,
                Categories = new List<string>
                {
                    "HY"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 58,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 59,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 60,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 61,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 62,
                Categories = new List<string>
                {
                    "AG", "OD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 63,
                Categories = new List<string>
                {
                    "IN", "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 64,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 65,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 66,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 67,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 68,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 69,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 70,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 71,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 72,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 73,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 74,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 75,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 76,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 77,
                Categories = new List<string>
                {
                    "IN", "AN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 78,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 79,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 80,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 81,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 82,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 83,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 84,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 85,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 86,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 87,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 88,
                Categories = new List<string>
                {
                    "HY"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 89,
                Categories = new List<string>
                {
                    "FR"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 90,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 91,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 92,
                Categories = new List<string>
                {
                    "HY"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 93,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 94,
                Categories = new List<string>
                {
                    "AG", "OD"
                }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 95,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 96,
                Categories = new List<string> { }
            },
            new Orchestrator.CategoryMap.CategoryMap
            {
                Id = 97,
                Categories = new List<string> { }
            }
        };
    }
}