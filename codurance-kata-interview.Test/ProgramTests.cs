namespace codurance_kata_interview.Test;

public class ProgramTests
{
    [Fact]
    public void RobotShouldExecuteCommandReceivedAndReturnCurrentPosition()
    {
        //given
        var expectedPosition = "0:0:N";
        Robot robot = new Robot();

        //when
        var command = "";
        var position = robot.Execute(command);        

        //then
        Assert.Equal(expectedPosition, position);
    }

    [Fact]
    public void RobotShouldRotateWhenReceivingDirectionLeft()
    {
        //given
        var expectedPosition = "0:0:W";
        Robot robot = new Robot();

        //when
        var command = "L";
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedPosition, position);
    }

    [Fact]
    public void RobotShouldRotateWhenReceivingDirectionRight()
    {
        //given
        var expectedPosition = "0:0:E";
        Robot robot = new Robot();

        //when
        var command = "R";
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedPosition, position);
    }

    [Fact]
    public void RobotShouldMoveWhenReceivingMoveCommand()
    {
        //given
        var expectedPosition = "0:1:N";
        Robot robot = new Robot();

        //when
        var command = "M";
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedPosition, position);
    }

    [Fact]
    public void RobotShouldMoveWestWhenReceivingLeftAndMoveCommand()
    {
        //given
        var expectedPosition = "-1:0:W";
        Robot robot = new Robot();

        //when
        var command = "LM";
        var position = robot.Execute(command);

        //then
        Assert.Equal(expectedPosition, position);
    }
}