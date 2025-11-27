package com.example.calculator;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.SeekBar;
import android.widget.Switch;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity implements View.OnClickListener, CompoundButton.OnCheckedChangeListener, SeekBar.OnSeekBarChangeListener {
    Button btnCalculate;
    RadioGroup radioGroup;
    RadioButton plus;
    RadioButton minus;
    RadioButton multiply;
    RadioButton divide;
    Switch swRound;
    SeekBar sbPrecision;
    EditText one;
    EditText two;
    double result = 0;

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
        swRound = findViewById(R.id.swRound);
        one = findViewById(R.id.editTextNumberDecimal);
        two = findViewById(R.id.editTextNumberDecimal2);
        sbPrecision = findViewById(R.id.sbPrecision);

        swRound.setOnCheckedChangeListener(this);

        sbPrecision.setOnSeekBarChangeListener(this);

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
        String oneText = one.getText().toString();
        String twoText = two.getText().toString();

        if (oneText.isEmpty() || twoText.isEmpty()) {
            Toast.makeText(MainActivity.this, "Please enter both numbers", Toast.LENGTH_SHORT).show();
            return;
        }

        double numOne = Double.parseDouble(oneText);
        double numTwo = Double.parseDouble(twoText);
        int selectedRadio = radioGroup.getCheckedRadioButtonId();

        if (selectedRadio == plus.getId()) {
            result = numOne + numTwo;
        } else if (selectedRadio == minus.getId()) {
            result = numOne - numTwo;
        } else if (selectedRadio == multiply.getId()) {
            result = numOne * numTwo;
        } else if (selectedRadio == divide.getId()) {
            if (numTwo == 0) {
                Toast.makeText(MainActivity.this, "Cannot divide by zero", Toast.LENGTH_SHORT).show();
                return;
            }
            result = numOne / numTwo;
        }

        String result2;

        if (swRound.isChecked()) {
            result = Math.round(result);
            result2 = String.valueOf((int) result);
        } else {
            int precision = sbPrecision.getProgress();
            if (precision > 0) {
                result2 = String.format("%." + precision + "f", result);
            } else {
                result2 = String.valueOf(result);
            }
        }

        Toast.makeText(MainActivity.this, "Result: " + result2, Toast.LENGTH_SHORT).show();
    }

    @Override
    public void onCheckedChanged(@NonNull CompoundButton buttonView, boolean isChecked) {

    }

    @Override
    public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {

    }

    @Override
    public void onStartTrackingTouch(SeekBar seekBar) {

    }

    @Override
    public void onStopTrackingTouch(SeekBar seekBar) {

    }
}