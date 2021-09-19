using System;
using System.Threading.Tasks;
using MineSweeper.Application.Interfaces;
using MineSweeper.Application.Services;
using MineSweeper.Application.ViewModels;
using MineSweeper.Domain.Entities;
using MineSweeper.Domain.Interfaces.Context;
using MineSweeper.Domain.Interfaces.Facades;
using MineSweeper.Domain.Interfaces.Repositories;
using NUnit.Framework;


namespace MineSweeper.UnitTest
{
    public class Tests
    {
        private readonly IGameAppService _service;
        private readonly IGameRepository _repository;
        private readonly IAuthFacade _facadeAuth;
        private readonly IUnitOfWork _uow;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            GameViewModel game = new GameViewModel();
      
            game.Id = Guid.NewGuid();
            game.Name = "unit test 1";
            game.Rows = 4;
            game.Cols = 4;
            game.Mines = 2;
            var _game = new Game(game.Name, game.Rows, game.Cols, game.Mines, Guid.NewGuid());
            Assert.Pass();
           
        }

        [Test]
        public async Task Test2()
        {
            Game game =  await _repository.GetById(Guid.NewGuid());

            if (game == null)
                throw new ArgumentException("Informed game doesn't exists!");
            Assert.Pass();

        }

        [Test]

        public async Task Test3()
        {

            GameViewModel game = new GameViewModel();

            game.Id = Guid.NewGuid();
            game.Name = "unit test 1";
            game.Rows = 4;
            game.Cols = 4;
            game.Mines = 2;

            var gameId = await _service.CreateGame(game);
            Assert.Pass();

        }


        [Test]
        public void Test4()
        {
            GameViewModel game = new GameViewModel();

            game.Id = Guid.NewGuid();
            game.Name = "unit test 4";
            game.Rows = 4;
            game.Cols = 4;
            game.Mines = 2;
            var _game = new Game(game.Name, game.Rows, game.Cols, game.Mines, Guid.NewGuid());
            Assert.Pass();

        }

        [Test]
        public void Test5()
        {
            GameViewModel game = new GameViewModel();

            game.Id = Guid.NewGuid();
            game.Name = "unit test 5";
            game.Rows = 4;
            game.Cols = 4;
            game.Mines = 2;
            var _game = new Game(game.Name, game.Rows, game.Cols, game.Mines, Guid.NewGuid());
            Assert.Pass();

        }

    }
}
