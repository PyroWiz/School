package com.example.testdemo;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    // 1. Declare your variables
    EditText etLesson1, etLesson2;
    Button btnCalculate;
    TextView tvResult;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        // 2. Initialize the views using the IDs from your XML
        etLesson1 = findViewById(R.id.TextBox1);
        etLesson2 = findViewById(R.id.TextBox2);
        btnCalculate = findViewById(R.id.calculate);
        tvResult = findViewById(R.id.Result);

        // 3. Set the click listener on the button
        btnCalculate.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        // 4. Implement the logic to count lessons
        if (v.getId() == R.id.calculate) {
            int count = 0;

            // Check if the first box has text (trim removes spaces)
            if (!etLesson1.getText().toString().trim().isEmpty()) {
                count++;
            }

            // Check if the second box has text
            if (!etLesson2.getText().toString().trim().isEmpty()) {
                count++;
            }

            // 5. Update the result text
            tvResult.setText("Total lessons: " + count);
        }
    }
}