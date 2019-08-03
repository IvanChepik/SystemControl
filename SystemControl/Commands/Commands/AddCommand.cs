namespace Commands.Commands
{
    public class AddCommand<T> : Command
    {
        private readonly T _addingEntity;

        public AddCommand(ExecutorCommands executorCommands, T addingEntity) : base(executorCommands)
        {
            _addingEntity = addingEntity;
        }

        public override void Execute()
        {
            Executor.Add(_addingEntity);
        }
    }
}