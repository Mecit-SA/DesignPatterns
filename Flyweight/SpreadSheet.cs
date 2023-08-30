namespace Flyweight
{
    public class SpreadSheet
    {
        private static readonly int MAX_ROWS = 3;
        private static readonly int MAX_COLS = 3;

        private readonly CellContextFactory _contextFactory;

        private readonly Cell[,] _cells = new Cell[3, 3];

        public SpreadSheet(CellContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            _cells[row, col].Content = content;
        }

        public void SetFontFamily(int row, int col, string fontFamily)
        {
            EnsureCellExists(row, col);

            var cell = _cells[row, col];
            var currentContext = cell.Context;
            var context = _contextFactory.GetContext(fontFamily, currentContext.FontSize, currentContext.IsBold);
            _cells[row, col].Context = context;
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentException();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col, GetDefaultContext());
                    _cells[row, col] = cell;
                }
        }

        private CellContext GetDefaultContext()
        {
            // In a real app, these values should not be hardcoded here.
            // They should be read from a configuration file.
            return new CellContext("Times New Roman", 12, false);
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    _cells[row, col].Render();
        }
    }
}