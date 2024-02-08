using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class Calculator : MonoBehaviour
{
    //TODO: Create a TextMeshProUGUI variable here and assign it in the inspector
    public TextMeshProUGUI label1;

    //TODO: Create a temporary float variable here called prevInput so we can store the previous input value
    //      when performaing calculations
    float prevInput;

    //TODO: Create a bool variable called clearPrevInput here so we can flip it to true/false if we should clear the prior input
    //      when typing in values. Example, if we type in the value 402 and then press the + button, the next value I enter
    //      should replace the 402 I previously entered
    bool clearPrevInput;

    //TODO: Leave this alone
    private EquationType equationType;

    private void Start()
    {
        Clear();
    }

    public void AddInput(string input)
    {
        //TODO: Check the clearPrevInput variable you created
        //      and if true then set the current value of the text label to be string.Empty
        //      and set the clearPrevInput value to false
        if (clearPrevInput == true) 
        {

            label1.text = string.Empty;
            clearPrevInput = false;
        
        }

        //TODO: Add the input passed into the AddInput function to the current value of the label
        //      Hint. You can perform the + operations on string data to combine them

        label1.text = label1.text + input;

    }

    public void SetEquationAsAdd()
    {
        //TODO: Store the current input value on the text label into the float variable you created.
        //      Hint. You will need to google float.Parse() and pass in the string value of the label.

        float.Parse(label1.text);

        //TODO: Set the bool you made to true so that the next number that gets typed in clears the calculator display.

        clearPrevInput = true;

        prevInput = float.Parse(label1.text);
        clearPrevInput = true;
        equationType = EquationType.ADD;
    }

    //TODO: Create a SetEquationAsSubtract function similar to SetEquationAsAdd.
    //      Make sure you set equationType to EquationType.SUBTRACT

    public void SetEquationAsSubtract()
    {
        //TODO: Store the current input value on the text label into the float variable you created.
        //      Hint. You will need to google float.Parse() and pass in the string value of the label.

        float.Parse(label1.text);

        //TODO: Set the bool you made to true so that the next number that gets typed in clears the calculator display.

        clearPrevInput = true;

        prevInput = float.Parse(label1.text);
        clearPrevInput = true;
        equationType = EquationType.SUBTRACT;
    }

    //TODO: Create a SetEquationAsMultiply function similar to SetEquationAsAdd.
    //      Make sure you set equationType to EquationType.Multiply

    public void SetEquationAsMultiply()
    {
        //TODO: Store the current input value on the text label into the float variable you created.
        //      Hint. You will need to google float.Parse() and pass in the string value of the label.

        float.Parse(label1.text);

        //TODO: Set the bool you made to true so that the next number that gets typed in clears the calculator display.

        clearPrevInput = true;

        prevInput = float.Parse(label1.text);
        clearPrevInput = true;
        equationType = EquationType.MULTIPLY;
    }

    //TODO: Create a SetEquationAsDivide function similar to SetEquationAsAdd.
    //      Make sure you set equationType to EquationType.DIVIDE

    public void SetEquationAsDivide()
    {
        //TODO: Store the current input value on the text label into the float variable you created.
        //      Hint. You will need to google float.Parse() and pass in the string value of the label.

        float.Parse(label1.text);

        //TODO: Set the bool you made to true so that the next number that gets typed in clears the calculator display.

        clearPrevInput = true;

        prevInput = float.Parse(label1.text);
        clearPrevInput = true;
        equationType = EquationType.DIVIDE;
    }

    public void Divide()
    {
        //TODO: Calculate the sum of the float variable that stores the previous input value and the current input value
        //      Set the text label to display that sum
        int input = Convert.ToInt16(label1.text);
        int input1 = Convert.ToInt16(prevInput);
        int quotient = input1 / input;
        label1.text = Convert.ToString(quotient);
    }

    //TODO: Implement Subtract function

    public void Subtract()
    {
        //TODO: Calculate the sum of the float variable that stores the previous input value and the current input value
        //      Set the text label to display that sum

        int input = Convert.ToInt16(label1.text);
        int input1 = Convert.ToInt16(prevInput);
        int result = input1 - input;
        label1.text = Convert.ToString(result);
    }

    //TODO: Implement Multiply function

    public void Multiply()
    {
        //TODO: Calculate the sum of the float variable that stores the previous input value and the current input value
        //      Set the text label to display that sum

        int input = Convert.ToInt16(label1.text);
        int input1 = Convert.ToInt16(prevInput);
        int result = input1 * input;
        label1.text = Convert.ToString(result);
    }

    //TODO: Implement Divide function

    public void Add()
    {
        //TODO: Calculate the sum of the float variable that stores the previous input value and the current input value
        //      Set the text label to display that sum

        int input = Convert.ToInt16(label1.text);
        int input1 = Convert.ToInt16(prevInput);
        int result = input1 + input;
        label1.text = Convert.ToString(result);
    }

    public void Clear()
    {
        //TODO: Reset the state of your calculator... reset the display value to a 0, reset the bool variable
        //      that represents if the display should be cleared to true, reset the temporary float variable as well to 0

        label1.text = "0";
        clearPrevInput = true;
        
            //TODO: Check if equationTypep is Add/Subtract/Multiply/Divide and call the correct function
            if (equationType == EquationType.ADD) Add();
            if (equationType == EquationType.SUBTRACT) Subtract();
            if (equationType == EquationType.MULTIPLY) Multiply();
            if (equationType == EquationType.DIVIDE) Divide();
        
    }

    //TODO: Leave this alone
    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }
}
