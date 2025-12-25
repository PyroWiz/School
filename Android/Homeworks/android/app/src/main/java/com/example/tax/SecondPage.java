package com.example.tax;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class SecondPage extends AppCompatActivity {

    TextView MainJobBox;
    TextView SecondJobBox;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_second_page);

        MainJobBox = findViewById(R.id.MainJobBox);
        SecondJobBox = findViewById(R.id.SecondJobBox);

        Intent intent = getIntent();
        int MainTax = intent.getIntExtra("MainCut", 0);
        int SecondTax = intent.getIntExtra("SecondCut", 0);
        boolean COORD = intent.getBooleanExtra("COORD", false);

        // Display tax values only if COORD is true
        if (COORD) {
            MainJobBox.setText(String.valueOf(MainTax));
            SecondJobBox.setText(String.valueOf(SecondTax));
        }


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}