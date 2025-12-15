package com.example.twoscreens;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.Switch;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @SuppressLint("UseSwitchCompatOrMaterialCode")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        Button button = findViewById(R.id.btnPage2);
        Switch swtcVisibility = findViewById(R.id.swtcVisibility);
        SeekBar seekOpacity = findViewById(R.id.seekOpacity);
        TextView txtImageOpinion = findViewById(R.id.txtImageOpinion);

        if (getIntent().getBooleanExtra("LIKE", false)) {
            txtImageOpinion.setText("swap image");
        } else
            txtImageOpinion.setText("you liked it");


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, DisplayImage.class);

                // 3. Get the current values
                boolean shouldShowImage = swtcVisibility.isChecked();
                int opacityValue = seekOpacity.getProgress();

                // 4. "Pack" the data into the intent
                // We give them key names ("IS_VISIBLE" and "OPACITY") to find them later
                intent.putExtra("IS_VISIBLE", shouldShowImage);
                intent.putExtra("OPACITY", opacityValue);

                startActivity(intent);
            }
        });
    }
}