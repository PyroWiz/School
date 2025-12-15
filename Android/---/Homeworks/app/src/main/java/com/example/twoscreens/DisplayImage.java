package com.example.twoscreens;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Switch;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class DisplayImage extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_display_image);

        Button button = findViewById(R.id.btnPage1);
        ImageView imgOne = findViewById(R.id.imgOne);
        Intent intent = getIntent();
        Switch swchLike = findViewById(R.id.swchLike);


        boolean isVisible = intent.getBooleanExtra("IS_VISIBLE", true);
        int opacity = intent.getIntExtra("OPACITY", 100);

        if (isVisible) {
            imgOne.setVisibility(View.VISIBLE);
        } else {
            imgOne.setVisibility(View.INVISIBLE);
        }

        imgOne.setAlpha(opacity / 100.0f);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                boolean like = swchLike.isChecked();
                Intent intent = new Intent(DisplayImage.this, MainActivity.class);
                intent.putExtra("LIKE", like);
                startActivity(intent);
            }
        });
    }
}