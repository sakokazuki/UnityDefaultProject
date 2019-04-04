//!! dependenciy Unity.cginc


// Stereographic projection and inverse projection
half2 StereoProjection(half3 n)
{
	return n.xy / (1 - n.z);
}

half3 StereoInverseProjection(half2 p)
{
	float d = 2 / (dot(p.xy, p.xy) + 1);
	return float3(p.xy * d, 1 - d);
}

//remap parameters x1~x2 to y1~y2
float remap(float value, float inputMin, float inputMax, float outputMin, float outputMax)
{
	return (value - inputMin) * ((outputMax - outputMin) / (inputMax - inputMin)) + outputMin;
}

//rectangular coordinate system ->  polar coordinate system
//ref https://www.shadertoy.com/view/Xsf3R4
float2 polarUv(float2 uv) {
	float w = uv.x - 0.5;
	float h = uv.y - 0.5;
	float distanceFromCenter = sqrt(w * w + h * h);
	float angle = remap(atan2(h, w), -UNITY_PI, UNITY_PI, 0.0, 1.0);


	return float2(angle, distanceFromCenter);;
}

//util curves ref: https://qiita.com/oishihiroaki/items/9d899cdcb9bee682531a
//gamma correct
float gammaCorrect(float gamma, float x)
{
	return pow(x, 1.0 / gamma);
}

//bias
float bias(float b, float x)
{
	return pow(x, log(b) / log(0.5));
}

//gain
float gain(float g, float x)
{
	if (x < 0.5)
	{
		return bias(1.0 - g, 2.0 * x) / 2.0;
	}
	else
	{
		return 1.0 - bias(1.0 - g, 2.0 - 2.0 * x) / 2.0;
	}
}