using PsychologicalAssessments.Orchestrator.CategoryMap;

namespace PsychologicalAssessments.Services.ConnersParent.CategoryMap;

public class ConnersParentCategoryMapFactory : ICategoryMapFactory
{
    private IEnumerable<Orchestrator.CategoryMap.CategoryMap>? _categories;

    public ConnersParentCategoryMapFactory()
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
                    "NI"
                }
            },
            new()
            {
                Id = 2,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new()
            {
                Id = 3,
                Categories = new List<string>
                {
                    "AH"
                }
            },
            new()
            {
                Id = 4,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 5,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 6,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 7,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 8,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new()
            {
                Id = 9,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 10,
                Categories = new List<string>
                {
                    "PR"
                }
            },
            new()
            {
                Id = 11,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 12,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new()
            {
                Id = 13,
                Categories = new List<string>
                {
                    "PR"
                }
            },
            new()
            {
                Id = 14,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new()
            {
                Id = 15,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 16,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new()
            {
                Id = 17,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 18,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new()
            {
                Id = 19,
                Categories = new List<string>
                {
                    "HY", "GI"
                }
            },
            new()
            {
                Id = 20,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 21,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new()
            {
                Id = 22,
                Categories = new List<string>
                {
                    "AG"
                }
            },
            new()
            {
                Id = 23,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new()
            {
                Id = 24,
                Categories = new List<string>
                {
                    "PR"
                }
            },
            new()
            {
                Id = 25,
                Categories = new List<string>
                {
                    "GI"
                }
            },
            new()
            {
                Id = 26,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new()
            {
                Id = 27,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new()
            {
                Id = 28,
                Categories = new List<string>
                {
                    "IN", "AN"
                }
            },
            new()
            {
                Id = 29,
                Categories = new List<string>
                {
                    "GI"
                }
            },
            new()
            {
                Id = 30,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new()
            {
                Id = 31,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new()
            {
                Id = 32,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new()
            {
                Id = 33,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new()
            {
                Id = 34,
                Categories = new List<string>
                {
                    "EF", "GI"
                }
            },
            new()
            {
                Id = 35,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new()
            {
                Id = 36,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 37,
                Categories = new List<string>
                {
                    "EF"
                }
            },
            new()
            {
                Id = 38,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new()
            {
                Id = 39,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new()
            {
                Id = 40,
                Categories = new List<string>
                {
                    "GI"
                }
            },
            new()
            {
                Id = 41,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 42,
                Categories = new List<string>
                {
                    "NI"
                }
            },
            new()
            {
                Id = 43,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 44,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new()
            {
                Id = 45,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 46,
                Categories = new List<string>
                {
                    "AG"
                }
            },
            new()
            {
                Id = 47,
                Categories = new List<string>
                {
                    "IN", "AN"
                }
            },
            new()
            {
                Id = 48,
                Categories = new List<string>
                {
                    "AG", "OD"
                }
            },
            new()
            {
                Id = 49,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new()
            {
                Id = 50,
                Categories = new List<string>
                {
                    "HY", "GI"
                }
            },
            new()
            {
                Id = 51,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 52,
                Categories = new List<string>
                {
                    "HY"
                }
            },
            new()
            {
                Id = 53,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 54,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 55,
                Categories = new List<string>
                {
                    "HY"
                }
            },
            new()
            {
                Id = 56,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 57,
                Categories = new List<string>
                {
                    "AG", "OD"
                }
            },
            new()
            {
                Id = 58,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new()
            {
                Id = 59,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new()
            {
                Id = 60,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 61,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 62,
                Categories = new List<string>
                {
                    "PR"
                }
            },
            new()
            {
                Id = 63,
                Categories = new List<string>
                {
                    "EF"
                }
            },
            new()
            {
                Id = 64,
                Categories = new List<string>
                {
                    "PR"
                }
            },
            new()
            {
                Id = 65,
                Categories = new List<string>
                {
                    "AG", "CD"
                }
            },
            new()
            {
                Id = 66,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 67,
                Categories = new List<string>
                {
                    "IN", "GI"
                }
            },
            new()
            {
                Id = 68,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new()
            {
                Id = 69,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 70,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 71,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 72,
                Categories = new List<string>
                {
                    "EF"
                }
            },
            new()
            {
                Id = 73,
                Categories = new List<string>
                {
                    "OD"
                }
            },
            new()
            {
                Id = 74,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new()
            {
                Id = 75,
                Categories = new List<string>
                {
                    "EF"
                }
            },
            new()
            {
                Id = 76,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 77,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new()
            {
                Id = 78,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 79,
                Categories = new List<string>
                {
                    "EF", "AN"
                }
            },
            new()
            {
                Id = 80,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new()
            {
                Id = 81,
                Categories = new List<string>
                {
                    "GI"
                }
            },
            new()
            {
                Id = 82,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 83,
                Categories = new List<string>
                {
                    "AG"
                }
            },
            new()
            {
                Id = 84,
                Categories = new List<string>
                {
                    "EF", "AN"
                }
            },
            new()
            {
                Id = 85,
                Categories = new List<string>
                {
                    "GI"
                }
            },
            new()
            {
                Id = 86,
                Categories = new List<string>
                {
                    "AG"
                }
            },
            new()
            {
                Id = 87,
                Categories = new List<string>
                {
                    "LP"
                }
            },
            new()
            {
                Id = 88,
                Categories = new List<string>
                {
                    "IN"
                }
            },
            new()
            {
                Id = 89,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 90,
                Categories = new List<string>
                {
                    "EF"
                }
            },
            new()
            {
                Id = 91,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 92,
                Categories = new List<string>
                {
                    "PR"
                }
            },
            new()
            {
                Id = 93,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 94,
                Categories = new List<string>
                {
                    "AG", "OD"
                }
            },
            new()
            {
                Id = 95,
                Categories = new List<string>
                {
                    "IN", "AN"
                }
            },
            new()
            {
                Id = 96,
                Categories = new List<string>
                {
                    "CD"
                }
            },
            new()
            {
                Id = 97,
                Categories = new List<string>
                {
                    "EF", "AN"
                }
            },
            new()
            {
                Id = 98,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 99,
                Categories = new List<string>
                {
                    "HY", "GI", "AH"
                }
            },
            new()
            {
                Id = 100,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 101,
                Categories = new List<string>
                {
                    "AN"
                }
            },
            new()
            {
                Id = 102,
                Categories = new List<string>
                {
                    "AG", "OD"
                }
            },
            new()
            {
                Id = 103,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 104,
                Categories = new List<string>
                {
                    "HY", "AH"
                }
            },
            new()
            {
                Id = 105,
                Categories = new List<string>
                {
                    "PI"
                }
            },
            new()
            {
                Id = 106,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 107,
                Categories = new List<string> { }
            },
            new()
            {
                Id = 108,
                Categories = new List<string> { }
            },
        };
    }
}