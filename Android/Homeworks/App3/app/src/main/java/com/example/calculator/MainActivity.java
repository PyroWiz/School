package com.example.calculator;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    Button btnCalculate;
    RadioGroup radioGroup;
    RadioButton plus;
    RadioButton minus;
    RadioButton multiply;
    RadioButton divide;

    EditText one;
    EditText two;


    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        btnCalculate = findViewById(R.id.btnCalculate);
        radioGroup = findViewById(R.id.radioGroup);
        plus = findViewById(R.id.plus);
        minus = findViewById(R.id.minus);
        multiply = findViewById(R.id.multiply);
        divide = findViewById(R.id.divide);

        one = findViewById(R.id.editTextNumberDecimal);
        two = findViewById(R.id.editTextNumberDecimal2);

        btnCalculate.setOnClickListener(this);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

    }

    @Override
    public void onClick(View v) {
        calculate();
    }

    private void calculate() {
        int selectedRadio = radioGroup.getCheckedRadioButtonId();
        // Get the text from EditTexts and parse to double
        String oneText = one.getText().toString();
        String twoText = two.getText().toString();
        double numOne = Double.parseDouble(oneText);
        double numTwo = Double.parseDouble(twoText);
        double result = 0;

        if (oneText.isEmpty() || twoText.isEmpty()) {
            Toast.makeText(MainActivity.this, "Please enter both numbers", Toast.LENGTH_SHORT).show();
            return;
        }


        if (selectedRadio == plus.getId()) {
            result = numOne + numTwo;
        } else if (selectedRadio == minus.getId()) {
            result = numOne - numTwo;
        } else if (selectedRadio == multiply.getId()) {
            result = numOne * numTwo;
        } else if (selectedRadio == divide.getId()) {
            // Add a check for division by zero
            if (numTwo == 0) {
                Toast.makeText(MainActivity.this, "Cannot divide by zero", Toast.LENGTH_SHORT).show();
                return;
            }
            result = numOne / numTwo;
        }
        Toast.makeText(MainActivity.this, "Result: " + result, Toast.LENGTH_SHORT).show();
    }
}
