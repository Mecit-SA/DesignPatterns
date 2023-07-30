namespace Command
{
    class VideoEditor
    {
        public float Contrast { get; set; } = 0.5f;
        public string Text { get; set; } = "Hello";

        public void RemoveText() => Text = string.Empty;

        public override string ToString()
        {
            return "VideoEditor{" +
                    "contrast=" + Contrast +
                    ", text='" + Text + '\'' +
                    '}';
        }
    }
}