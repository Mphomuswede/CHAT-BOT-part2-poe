using Microsoft.ML.Data;

public class SentimentData
{
    public string SentimentText { get; set; }
}

public class SentimentPrediction : SentimentData
{
    public float Prediction { get; set; }
    public float Probability { get; set; }
}
