namespace wf_poll_cwe
{
    public struct PollResult
    {
        public int Total;
        public double Percent;

        public PollResult(int total, double percent)
        {
            this.Total = total;
            this.Percent = percent;
        }
    }
}
