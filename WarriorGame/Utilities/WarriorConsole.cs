using Spectre.Console;
using WarriorGame.Models;
using WarriorGame.Models.Interfaces;

namespace WarriorGame.Utilities
{
    public static class WarriorConsole
    {
        private static readonly Style WarriorStyle = new(Color.Blue);
        private static readonly Style WeaponStyle = new(Color.Green);
        private static readonly Style ActionStyle = new(Color.Yellow);
        private static readonly Style AttackStyle = new(Color.Red);

        public static readonly Dictionary<string, string> WeaponIcons = new Dictionary<string, string>
        {
            { "Axe", Emoji.Known.Axe},
            { "Bow", Emoji.Known.BowAndArrow},
            { "Club", Emoji.Known.CricketGame},
            { "Crossbow", Emoji.Known.BowAndArrow},
            { "Dagger", Emoji.Known.Dagger},
            { "Halberd", Emoji.Known.Pick},
            { "Spear", Emoji.Known.TridentEmblem},
            { "Staff", Emoji.Known.WhiteCane},
            { "Sword", Emoji.Known.KitchenKnife},
            { "WarHammer", Emoji.Known.Hammer},          
        };

        private static readonly string WarriorIcon = "\U0001F9D4\U0001F3FB";
        private static readonly string VikingRune = "ᛟ";
        public static readonly string AttackIcon = Emoji.Known.CrossedSwords;
        public static readonly string DamageIcon = Emoji.Known.Collision;
        

        public static void Initialize()
        {
            AnsiConsole.Write(
                new FigletText("The Viking Warrior")
                .Centered()
                .Color(Color.Red));

            AnsiConsole.WriteLine();
        }

        public static void DisplayWarriorStat(Warrior warrior)
        {
            var panel = new Panel($"{WarriorIcon} {warrior.Name}")
            {
                Border = BoxBorder.Double,
                BorderStyle = WarriorStyle,
                Header = new PanelHeader("Viking Warrior:"),
                Expand = false,
                Padding = new Padding(1, 0, 1, 0)
            };
            AnsiConsole.Write(panel);

            var weaponPanel = new Panel($"{WeaponIcons[warrior.Weapon.Name]} {warrior.Weapon.Name}")
            {
                Border = BoxBorder.Rounded,
                BorderStyle = WeaponStyle,
                Header = new PanelHeader("Chosen Weapon:"),
                Expand = false,
                Padding = new Padding(1, 0, 1, 0)
            };
            AnsiConsole.Write(weaponPanel);
        }

        public static void DisplayAction(Warrior warrior, string action)
        {
            var actionPanel = new Panel($"{VikingRune} {warrior.Name} {action}")
            {
                Border = BoxBorder.Heavy,
                BorderStyle = ActionStyle,
                Expand = false,
                Padding = new Padding(1, 0, 1, 0)
            };
            AnsiConsole.Write(actionPanel);
        }

        public static void DisplayWarriorAttack(Warrior warrior, string warriorAttackDescription)
        {
            var warriorAttackPanel = new Panel($"{warriorAttackDescription} ")
            {
                Border = BoxBorder.Heavy,
                BorderStyle = AttackStyle,
                Expand = false,
                Padding = new Padding(1, 0, 1, 0)
            };
            AnsiConsole.Write(warriorAttackPanel);
        }

        public static void DisplayWeaponAttack(IWeapon weapon, string attackDescription)
        {
            var attackPanel = new Panel($"{attackDescription} ")
            {
                Border = BoxBorder.Heavy,
                BorderStyle = AttackStyle,
                Expand = false,
                Padding = new Padding(1, 0, 1, 0)
            };
            AnsiConsole.Write(attackPanel);
        }

        public static bool ConfirmAction(string question)
        {
            return AnsiConsole.Confirm(question);
        }

        public static void DisplayWeaponChange(Warrior warrior, string oldWeapon)
        {
            AnsiConsole.MarkupLine($"[bold]Weapon changed:[/] {WeaponIcons[oldWeapon]} [strikethrough]{oldWeapon}[/] -> {WeaponIcons[warrior.Weapon.Name]} [underline]{warrior.Weapon.Name}[/]");
        }

        public static void EndGame()
        {
            AnsiConsole.Write(new Rule("[yellow]The Battle has ended![/]")
                .DoubleBorder()
                .RuleStyle(Style.Parse("yellow bold"))
                .Centered());

            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Markup("[green]The Viking Warrior has emerged victorious![/]").Centered());
            AnsiConsole.WriteLine();
        }
    }
}
