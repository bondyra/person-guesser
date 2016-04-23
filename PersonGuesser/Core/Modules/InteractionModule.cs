﻿using Core.Data;

namespace Core.Modules
{
    public class InteractionModule : IInteraction
    {
        private Modules.DataModule _dataModule;

        public InteractionModule()
        {
        }

        public void StartGame()
        {
            _dataModule = new Modules.DataModule( new GameData() );
        }

        public Step GetStep()
        {
            return _dataModule.GetStep();
        }

        public void SaveAnswer(AnswerType answer)
        {
            _dataModule.ProcessAnswer(answer);
        }

        public GameSummary GetSummary()
        {
            return _dataModule.GetSummary();
        }

        public void EndGame()
        {
            _dataModule.EndGame();
        }

        public void AddNewQuestion(string text)
        {
            UpdatingModule.Instance.AddNewQuestion(text);
        }

        public void AddNewPerson(string name)
        {
            UpdatingModule.Instance.AddNewPerson(name, _dataModule.GetSummary());
        }
    }
}