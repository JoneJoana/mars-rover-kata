namespace codurance_kata_interview.Test;

public class RobotTests
{
    Plateau plateau;
    public RobotTests() 
    {
        plateau = new Plateau(10, 10);
    } 

    [Fact]
    public void RobotShouldExecuteCommandReceivedAndReturnCurrentPosition()
    {
        //given
        var expectedPosition = "0:0:N";
        Robot robot = new Robot(plateau);

        //when
        var command = "";
        var position = robot.Execute(command);        

        //then
        Assert.Equal(expectedPosition, position);
    }

    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    [InlineData("LLLL", "0:0:N")]
    public void RobotShouldRotateWhenReceivingDirectionLeft(string command, string expectedFinalPosition)
    {
        //given
        Robot robot = new Robot(plateau);

        //when        
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedFinalPosition, position);
    }

    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRR", "0:0:N")]
    public void RobotShouldRotateWhenReceivingDirectionRight(string command, string expectedFinalPosition)
    {
        //given
        Robot robot = new Robot(plateau);

        //when
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedFinalPosition, position);
    }

    [Theory]
    [InlineData("M", "0:1:N")]
    [InlineData("MM", "0:2:N")]
    [InlineData("MMM", "0:3:N")]
    public void RobotShouldMoveWhenReceivingMoveCommand(string command, string expectedFinalPosition)
    {
        //given
        Robot robot = new Robot(plateau);

        //when
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedFinalPosition, position);
    }

    [Theory]
    [InlineData("LM", "9:0:W")]
    [InlineData("LML", "9:0:S")]
    [InlineData("MRMLLM", "0:1:W")]
    [InlineData("MMRMMLM ", "2:3:N")]
    public void RobotShouldMoveWhenReceivingDirectionAndMoveCommands(string command, string expectedFinalPosition)
    {
        //given
        Robot robot = new Robot(plateau);

        //when
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedFinalPosition, position);
    }


    [Theory]
    [InlineData("LM", "LM", "9:9:S")]
    [InlineData("LM", "LMM", "9:8:S")]
    [InlineData("RM", "RMMR", "1:8:W")]
    [InlineData("RMM", "RM", "2:9:S")]
    public void RobotShouldSaveItsStateAfterEachExecute(string command1, string command2, string expectedFinalPosition)
    {        
        Robot robot = new Robot(plateau);

        //when
        _ = robot.Execute(command1);
        var finalPosition = robot.Execute(command2);

        //then
        Assert.Equal(expectedFinalPosition, finalPosition);
    }

    [Theory]
    [InlineData("MMMMMMMMMMMM", "0:2:N")]
    [InlineData("RMMMMMMMMMMMM", "2:0:E")]
    [InlineData("LMM", "8:0:W")]
    [InlineData("RRMM", "0:8:S")]
    public void RobotShouldWrapAroundnWhenReachedPlateauLimit(string command, string expectedFinalPosition)
    {
        //given
        Robot robot = new Robot(plateau);

        //when
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedFinalPosition, position);
    }

}