package com.example.test;

import static java.lang.Double.parseDouble;

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

    EditText TextBox1;
    EditText TextBox2;
    EditText TextBox3;

    Button btnRecommend;

    TextView textRecommendation;


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

        TextBox1 = findViewById(R.id.editTextNumber);
        TextBox2 = findViewById(R.id.editTextNumber2);
        TextBox3 = findViewById(R.id.editTextNumber3);
        btnRecommend = findViewById(R.id.btnRecommend);
        textRecommendation = findViewById(R.id.textRecommendation);

        btnRecommend.setOnClickListener(this);


    }

    @Override
    public void onClick(View v) {
        String ios = TextBox1.getText().toString();
        String android = TextBox2.getText().toString();
        String cross = TextBox3.getText().toString();

        double iosnum = Double.parseDouble(ios);
        double androidnum = Double.parseDouble(android);
        double crossnum = Double.parseDouble(cross);

        double highest = 0;
        String field = "";


        if (v.getId() == R.id.btnRecommend) {

            if (iosnum > highest) {
                highest = iosnum;
                field = "IOS";
            }
            if (androidnum > highest) {
                highest = androidnum;
                field = "Android";
            }
            if (crossnum > highest) {
                field = "Cross Platform";
            }


            textRecommendation.setText("Recommended field: " + field);
        }
    }
}