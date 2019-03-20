using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashFrameData.Model
{
    class CharacterManager
    {
        private List<Character> characterList = new List<Character>();
        private string s_response = String.Empty;

        public CharacterManager()
        {
            characterList.Add(new Character("Mario"));
            characterList.Add(new Character("Donkey Kong"));
            characterList.Add(new Character("Link"));
            characterList.Add(new Character("Samus"));
            characterList.Add(new Character("Dark Samus"));
            characterList.Add(new Character("Yoshi"));
            characterList.Add(new Character("Kirby"));
            characterList.Add(new Character("Pikachu"));
            characterList.Add(new Character("Luigi"));
            characterList.Add(new Character("Ness"));
            characterList.Add(new Character("Captain Falcon"));
            characterList.Add(new Character("Jigglipuff"));
            characterList.Add(new Character("Peach"));
            characterList.Add(new Character("Daisy"));
            characterList.Add(new Character("Bowser"));
            characterList.Add(new Character("Ice Climbers"));
            characterList.Add(new Character("Sheik"));
            characterList.Add(new Character("Zelda"));
            characterList.Add(new Character("Dr Mario"));
            characterList.Add(new Character("Pichu"));
            characterList.Add(new Character("Falco"));
            characterList.Add(new Character("Marth"));
            characterList.Add(new Character("Lucina"));
            characterList.Add(new Character("Young Link"));
            characterList.Add(new Character("Mewtwo"));
            characterList.Add(new Character("Roy"));
            characterList.Add(new Character("Chrom"));
            characterList.Add(new Character("Mr Game And Watch"));
            characterList.Add(new Character("Meta Knight"));
            characterList.Add(new Character("Pit"));
            characterList.Add(new Character("Dark Pit"));
            characterList.Add(new Character("Zero Suit Samus"));
            characterList.Add(new Character("Wario"));
            characterList.Add(new Character("Snake"));
            characterList.Add(new Character("Ike"));
            characterList.Add(new Character("Pokemon Trainer"));
            characterList.Add(new Character("Diddy Kong"));
            characterList.Add(new Character("Lucas"));
            characterList.Add(new Character("Sonic"));
            characterList.Add(new Character("King Dedede"));
            characterList.Add(new Character("Olimar"));
            characterList.Add(new Character("Lucario"));
            characterList.Add(new Character("ROB"));
            characterList.Add(new Character("Toon Link"));
            characterList.Add(new Character("Wolf"));
            characterList.Add(new Character("Villager"));
            characterList.Add(new Character("Megaman"));
            characterList.Add(new Character("Wii Fit Trainer"));
            characterList.Add(new Character("Rosalina and Luma"));
            characterList.Add(new Character("Little Mac"));
            characterList.Add(new Character("Greninja"));
            characterList.Add(new Character("Palutena"));
            characterList.Add(new Character("Pacman"));
            characterList.Add(new Character("Robin"));
            characterList.Add(new Character("Shulk"));
            characterList.Add(new Character("Bowser Jr"));
            characterList.Add(new Character("Duck Hunt"));
        }

        public async Task<List<string>> SearchForCharacterAsync(string characterName)
        {
            List<string> nameMatches = new List<string>();

            var task = Task.Factory.StartNew(() =>
            {
                var searchQuery =
                from searchedCharacter in characterList.AsParallel().AsOrdered()
                where searchedCharacter.Name.ToLower().Contains(characterName.ToLower())
                orderby searchedCharacter.Name
                select searchedCharacter;

                foreach (var c in searchQuery)
                {
                    nameMatches.Add(c.Name);
                }
            });

            var anotherTask = Task.Delay(2000);

            await Task.WhenAll(task, anotherTask);

            return nameMatches;
        }
    }
}
