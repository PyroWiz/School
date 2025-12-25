package com.example.tax;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.ToggleButton;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    SeekBar MainJobSeek;
    SeekBar SecondJobSeek;
    ToggleButton CoordToggle;
    Button SendBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        MainJobSeek = findViewById(R.id.MainJobSeek);
        SecondJobSeek = findViewById(R.id.SecondJobSeek);
        CoordToggle = findViewById(R.id.CoordToggle);
        SendBtn = findViewById(R.id.SendBtn);

        SendBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int MainJobAmount = MainJobSeek.getProgress();
                int SecondJobAmount = SecondJobSeek.getProgress();
                int MainCut = (int) (MainJobAmount * 0.40);
                int SecondCut = (int) (SecondJobAmount * 0.10);
                boolean coordToggle = CoordToggle.isChecked();

                Intent intent = new Intent(MainActivity.this, SecondPage.class);
                intent.putExtra("MainCut", MainCut);
                intent.putExtra("SecondCut", SecondCut);
                intent.putExtra("COORD",coordToggle);
                startActivity(intent);
            }
        });


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}