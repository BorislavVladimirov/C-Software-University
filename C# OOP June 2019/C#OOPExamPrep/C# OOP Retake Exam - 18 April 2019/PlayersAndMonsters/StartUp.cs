namespace PlayersAndMonsters
{
    using Core;
    using Core.Contracts;
    using Core.Factories;
    using Core.Factories.Contracts;
    using Repositories;
    using Repositories.Contracts;
    using IO;
    using IO.Contracts;
    using Models.BattleFields;
    using Models.BattleFields.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IWriter writer = new Writer();
            IReader reader = new Reader();

            IPlayerRepository playerRepository = new PlayerRepository();
            ICardRepository cardRepository = new CardRepository();

            ICardFactory cardFactory = new CardFactory();
            IPlayerFactory playerFactory = new PlayerFactory();

            IBattleField battleField = new BattleField();

            IManagerController managerController = new ManagerController(playerRepository, cardFactory, playerFactory, cardRepository, battleField);


            IEngine engine = new Engine(writer, reader, managerController);

            engine.Run();
        }
    }
}