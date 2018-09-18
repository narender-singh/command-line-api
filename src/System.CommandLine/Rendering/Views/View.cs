namespace System.CommandLine.Rendering.Views
{
    public abstract class View
    {
        public event EventHandler Updated;

        public abstract void Render(Region region, IRenderer renderer);

        public abstract Size Measure(IRenderer renderer, Size maxSize);

        protected void OnUpdated() => Updated?.Invoke(this, EventArgs.Empty);
    }
}
