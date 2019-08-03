using Models;

namespace Commands.Commands
{
    public class InitTableCommand<T> : Command
    {
        private ModelsType _modelType;

        public InitTableCommand(ExecutorCommands executorCommands, ModelsType modelType) : base(executorCommands)
        {
            _modelType = modelType;
        }

        public override void Execute()
        {
            Executor.InitDataBase<T>(_modelType);
        }
    }
}