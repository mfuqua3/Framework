using Bogus;

namespace Framework.Testing.Extensions;

internal static class FakerExtensions
{
    public static T PickRandomExcept<T>(this Faker faker, Func<T, bool> filter) where T : struct, Enum =>
        faker.PickRandom(Enum.GetValues<T>()
            .Where(x => !filter(x))
            .ToList());

    public static int Mrn(this Randomizer r)
	    => r.Number(max: int.MaxValue);
}