using Models;

namespace Commands.Commands
{
    public class DeleteCommand : Command
    {
        private ModelsType _modelType;

        private int _id;

        public DeleteCommand(ExecutorCommands executorCommands, ModelsType type, int id) : base(executorCommands)
        {
            _modelType = type;
            _id = id;
        }

        public override void Execute()
        {
            Executor.Delete(_modelType, _id);
        }
    }
}
