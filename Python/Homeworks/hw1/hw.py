import math
import cmath

a = 3
b = 4
c = float(math.sqrt(a**2+b**2))

print(f"last side is {c}")

cos_A = (b**2 + c**2 - a**2) / (2 * b * c)
angle_A_rad = math.acos(cos_A)
angle_A_deg = math.degrees(angle_A_rad)

cos_B = (a**2 + c**2 - b**2) / (2 * a * c)
angle_B_rad = math.acos(cos_B)
angle_B_deg = math.degrees(angle_B_rad)

angle_C_deg = 180.0 - angle_A_deg - angle_B_deg

print(f"Angle A: {round(angle_A_deg, 2)},Angle B: {round(angle_B_deg, 2)} Angle C: {round(angle_C_deg, 2)}")