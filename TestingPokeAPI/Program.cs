using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TestingGet;
using System.ComponentModel.Design;


namespace TestingGet
{
    public class Ability1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability2
    {
        public Ability1 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndice1
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Move1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
        public VersionGroup version_group { get; set; }
    }

    public class Move2
    {
        public Move1 move { get; set; }
        public IList<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class DreamWorld
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class Home
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class Other
    {
        public DreamWorld dream_world { get; set; }
        public Home home { get; set; }
        public OfficialArtwork official_artwork { get; set; }
    }

    public class RedBlue
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
        public string front_transparent { get; set; }
    }

    public class Yellow
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
        public string front_transparent { get; set; }
    }

    public class GenerationI
    {
        public RedBlue red_blue { get; set; }
        public Yellow yellow { get; set; }
    }

    public class Crystal
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_transparent { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_transparent { get; set; }
        public string front_transparent { get; set; }
    }

    public class Gold
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_transparent { get; set; }
    }

    public class Silver
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_transparent { get; set; }
    }

    public class GenerationIi
    {
        public Crystal crystal { get; set; }
        public Gold gold { get; set; }
        public Silver silver { get; set; }
    }

    public class Emerald
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class FireredLeafgreen
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class RubySapphire
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class GenerationIii
    {
        public Emerald emerald { get; set; }
        public FireredLeafgreen firered_leafgreen { get; set; }
        public RubySapphire ruby_sapphire { get; set; }
    }

    public class DiamondPearl
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Platinum
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationIv
    {
        public DiamondPearl diamond_pearl { get; set; }
        public HeartgoldSoulsilver heartgold_soulsilver { get; set; }
        public Platinum platinum { get; set; }
    }

    public class Animated
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class BlackWhite
    {
        public Animated animated { get; set; }
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationV
    {
        public BlackWhite black_white { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class XY
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationVi
    {
        public OmegarubyAlphasapphire omegaruby_alphasapphire { get; set; }
        public XY xy { get; set; }
    }

    public class Icons
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class UltraSunUltraMoon
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationVii
    {
        public Icons icons { get; set; }
        public UltraSunUltraMoon ultra_sun_ultra_moon { get; set; }
    }

    public class GenerationViii
    {
        public Icons icons { get; set; }
    }

    public class Versions
    {
        public GenerationI generation_i { get; set; }
        public GenerationIi generation_ii { get; set; }
        public GenerationIii generation_iii { get; set; }
        public GenerationIv generation_iv { get; set; }
        public GenerationV generation_v { get; set; }
        public GenerationVi generation_vi { get; set; }
        public GenerationVii generation_vii { get; set; }
        public GenerationViii generation_viii { get; set; }
    }

    public class Sprites
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
        public Other other { get; set; }
        public Versions versions { get; set; }
    }

    public class Stat1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat2
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat1 stat { get; set; }
    }

    public class Type1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type2
    {
        public int slot { get; set; }
        public Type1 type { get; set; }
    }

    public class PokeAPI
    {
        public IList<Ability2> abilities { get; set; }
        public int base_experience { get; set; }
        public IList<Form> forms { get; set; }
        public IList<GameIndice1> game_indices { get; set; }
        public int height { get; set; }
        public IList<object> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public IList<Move2> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public IList<object> past_abilities { get; set; }
        public IList<object> past_types { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public IList<Stat2> stats { get; set; }
        public IList<Type2> types { get; set; }
        public int weight { get; set; }
    }

    public class DoubleDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class DoubleDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class HalfDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class HalfDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class NoDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class NoDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }


    public class DamageRelations
    {
        public IList<DoubleDamageFrom> double_damage_from { get; set; }
        public IList<DoubleDamageTo> double_damage_to { get; set; }
        public IList<HalfDamageFrom> half_damage_from { get; set; }
        public IList<HalfDamageTo> half_damage_to { get; set; }
        public IList<NoDamageFrom> no_damage_from { get; set; }
        public IList<NoDamageTo> no_damage_to { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndice2
    {
        public int game_index { get; set; }
        public Generation generation { get; set; }
    }

    public class MoveDamageClass
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name
    {
        public Language language { get; set; }
        public string name { get; set; }
    }

    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Pokemon2
    {
        public Pokemon pokemon { get; set; }
        public int slot { get; set; }
    }

    public class PokeAPI2
    {
        public DamageRelations damage_relations { get; set; }
        public IList<GameIndice2> game_indices { get; set; }
        public Generation generation { get; set; }
        public int id { get; set; }
        public MoveDamageClass move_damage_class { get; set; }
        public IList<Move> moves { get; set; }
        public string name { get; set; }
        public IList<Name> names { get; set; }
        public IList<object> past_damage_relations { get; set; }
        public IList<Pokemon> pokemon { get; set; }
    }


    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Name your Pokemon");
            var name = Console.ReadLine();

            using (HttpClient client = new HttpClient())
            {

                //Console.WriteLine("Calling WebAPI...");
                var responseTask1 = client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}/");
                responseTask1.Wait();

                if (responseTask1.IsCompleted)
                {
                    var result1 = responseTask1.Result;
                    if (result1.IsSuccessStatusCode)
                    {

                        string JsonResult = await result1.Content.ReadAsStringAsync();
                        var pokemonData1 = JsonConvert.DeserializeObject<TestingGet.PokeAPI>(JsonResult);
                    

                        //Console.WriteLine($"Pokemon ID: {pokemonData1.id}");

                        //next 3 lines are for abilities and shows in a list. Use 'foreach'
                        //Console.WriteLine("Abilities: ");

                        foreach (var ability in pokemonData1.abilities)
                        {
                            //Console.WriteLine($"- {ability.ability.name}");
                        }


                        if (pokemonData1 != null)
                        {
                            int firstApiId = pokemonData1.id;

                            //Console.WriteLine("Calling WebAPI 2...");
                            var responseTask2 = await client.GetAsync($"https://pokeapi.co/api/v2/type/{firstApiId}/");

                            if (responseTask2.IsSuccessStatusCode)
                            {
                                string JsonResult2 = await responseTask2.Content.ReadAsStringAsync();

                                TestingGet.PokeAPI2 pokemonData2 = JsonConvert.DeserializeObject<TestingGet.PokeAPI2>(JsonResult2);



                                foreach (var doubleDamageFrom in pokemonData2.damage_relations.double_damage_from)
                                {

                                    Console.WriteLine($"Double Damage From: {doubleDamageFrom.name}");
                                }

                                foreach (var halfDamageFrom in pokemonData2.damage_relations.half_damage_from)
                                {

                                    Console.WriteLine($"Half Damage From: {halfDamageFrom.name}");
                                }

                                foreach (var noDamageFrom in pokemonData2.damage_relations.no_damage_from)
                                {


                                    Console.WriteLine($"No Damage From: {noDamageFrom.name}");
                                }

                                foreach (var noDamageTo in pokemonData2.damage_relations.no_damage_to)
                                {

                                    Console.WriteLine($"No Damage To: {noDamageTo.name}");
                                }

                                foreach (var halfDamageTo in pokemonData2.damage_relations.half_damage_to)
                                {

                                    Console.WriteLine($"Half Damage To: {halfDamageTo.name}");
                                }

                                foreach (var doubleDamageTo in pokemonData2.damage_relations.double_damage_to)
                                {

                                    Console.WriteLine($"Double Damage To: {doubleDamageTo.name}");
                                }



                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("That's not a Pokemon");
                        return;
                    }

                }
            }
        }
    }
}
