import os
import random

def sandwich_corruption():
    input_file = "input.mp4"
    output_file = "glitch_sandwich.mp4"
    
    # CONFIGURATION
    # Total length of your input video in seconds (approx)
    total_video_length = 80  # 1:20
    # How many seconds you want to play normally
    safe_seconds = 30
    
    try:
        with open(input_file, 'rb') as f:
            data = bytearray(f.read())
            
        file_size = len(data)
        
        # 1. Calculate the Cut Points
        # Point A: Where to START corrupting (after 30 seconds)
        start_corruption_index = int(file_size * (safe_seconds / total_video_length))
        
        # Point B: Where to STOP corrupting (Keep the last 5% safe for the Index)
        # We preserve the last 5% of the file to ensure the header/footer survives
        footer_safety_margin = int(file_size * 0.05) 
        stop_corruption_index = file_size - footer_safety_margin

        print(f"File Size: {file_size / 1024 / 1024:.2f} MB")
        print(f"Safe Zone (Start): 0 to {start_corruption_index} bytes")
        print(f"Safe Zone (End): {stop_corruption_index} to {file_size} bytes")
        print("Corrupting the middle section...")

        # 2. Generate Random Junk for the Middle
        corruption_length = stop_corruption_index - start_corruption_index
        junk_data = os.urandom(corruption_length)

        # 3. Assemble the Sandwich
        # [Safe Start] + [Junk Middle] + [Safe End]
        final_data = data[:start_corruption_index] + junk_data + data[stop_corruption_index:]
        
        with open(output_file, 'wb') as f:
            f.write(final_data)
            
        print(f"Success! Created '{output_file}'")
        print("Open this file. It should play 30 seconds, then break, but the file structure remains valid.")

    except FileNotFoundError:
        print("Error: Could not find 'input.mp4'.")
    except Exception as e:
        print(f"An error occurred: {e}")

if __name__ == "__main__":
    sandwich_corruption()