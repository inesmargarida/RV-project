﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class gen2 : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballPrefabMov1;
    public GameObject ballPrefabMov1b;
    public GameObject ballPrefabMov2;
    public GameObject ballPrefabMov2b;
    public GameObject ballPrefabMov3;
    public GameObject ballPrefabMov3b;
    public GameObject ballPrefabMov4;
    public GameObject ballPrefabMov4b;
    public GameObject ballPrefabMov5;
    public int nrStillBalls;
    public int nrMov1Balls;
    public int nrMov1bBalls;
    public int nrMov2Balls;
    public int nrMov2bBalls;
    public int nrMov3Balls;
    public int nrMov3bBalls;
    public int nrMov4Balls;
    public int nrMov4bBalls;
    public int nrMov5Balls;

    float speed = 0.5f;


    // 150 balls, use prints of randoms for more
    List<double> x_values = new List<double>() { -1.086294, -1.086294, -0.3047414, -0.3047414, 0.05347443, 0.05347443, -4.400624, -4.400624, 4.565177, 4.565177, 2.500253, 2.500253, 4.978668, 4.978668, -1.274769, -1.274769, -4.313384, -4.313384, -1.631732, -1.631732, 3.324503, 3.324503, -4.623621, -4.623621, -4.996294, -4.996294, 4.210602, 4.210602, -1.014509, -1.014509, 0.4142542, 0.4142542, -0.5203013, -0.5203013, 0.8855038, 0.8855038, -0.4076486, -0.4076486, -3.22132, -3.22132, -1.117911, -1.117911, 3.120012, 3.120012, 4.552813, 4.552813, -2.372837, -2.372837, 1.06389, 1.06389, -1.30811, -1.30811, 3.077156, 3.077156, 1.387111, 1.387111, 3.377216, 3.377216, 3.337648, 3.337648, -0.9524436, -0.9524436, 2.202833, 2.202833, -3.110599, -3.110599, 2.422911, 2.422911, -4.804426, -4.804426, 4.993864, 4.993864, -1.16559, -1.16559, -2.242702, -2.242702, 4.040922, 4.040922, -2.728279, -2.728279, 0.9738259, 0.9738259, -2.593648, -2.593648, 4.132499, 4.132499, 2.702737, 2.702737, -2.837672, -2.837672, -4.4408, -4.4408, 2.43719, 2.43719, -2.767263, -2.767263, 0.4306393, 0.4306393, -2.637787, -2.637787, -2.245639, -2.245639, 4.706833, 4.706833, -0.9856849, -0.9856849, -1.672294, -1.672294, 3.208563, 3.208563, -4.209375, -4.209375, -0.5295401, -0.5295401, 4.215556, 4.215556, 2.423284, 2.423284, -0.2443929, -0.2443929, 0.2983289, 0.2983289, 2.162012, 2.162012, -4.261869, -4.261869, 1.564933, 1.564933, 3.310398, 3.310398, -3.661015, -3.661015, 0.1684599, 0.1684599, -3.774018, -3.774018, 0.2505012, 0.2505012, -3.992482, -3.992482, -1.214254, -1.214254, -3.039408, -3.039408, -3.77017, -3.77017, 2.669001, 2.669001, -3.756585, -3.756585, -1.780562, -1.780562, -4.663276, -4.663276, 0.5011754, 0.5011754, -0.7155852, -0.7155852, -2.07362, -2.07362, 0.293117, 0.293117, -2.795955, -2.795955, -1.785729, -1.785729, -1.058674, -1.058674, -4.530849, -4.530849, -4.613312, -4.613312, -1.332214, -1.332214, -3.287865, -3.287865, -4.027445, -4.027445, -2.339998, -2.339998, -3.941035, -3.941035, -4.845857, -4.845857, -4.066202, -4.066202, -4.038157, -4.038157, -1.738691, -1.738691, 1.743221, 1.743221, -3.113004, -3.113004, 0.1945119, 0.1945119, -1.442751, -1.442751, -0.532866, -0.532866, -1.148873, -1.148873, -4.200686, -4.200686, 3.860568, 3.860568, -1.596894, -1.596894, 0.5710249, 0.5710249, -2.743385, -2.743385, -1.704205, -1.704205, -0.6754751, -0.6754751, -2.615433, -2.615433, -3.235365, -3.235365, -3.516131, -3.516131, -2.445229, -2.445229, 0.1360245, 0.1360245, 2.779492, 2.779492, -4.916073, -4.916073, 1.556195, 1.556195, 1.68508, 1.68508, -1.280654, -1.280654, 4.733402, 4.733402, 4.501351, 4.501351, -2.918233, -2.918233, 1.776386, 1.776386, 3.445315, 3.445315, -3.53534, -3.53534, 4.555208, 4.555208, -3.449905, -3.449905, 1.768121, 1.768121, -3.183426, -3.183426, -4.428698, -4.428698, 4.342307, 4.342307, 1.402168, 1.402168, -4.871634, -4.871634, 3.138714, 3.138714, -4.544507, -4.544507, 3.952202, 3.952202, 2.983247, 2.983247, -1.302805, -1.302805, -4.160513, -4.160513, -4.745341, -4.745341, -3.182813, -3.182813, -3.336711, -3.336711, -1.350646, -1.350646, 1.203948, 1.203948, -0.8507032, -0.8507032, 0.8486981, 0.8486981, 1.800331, 1.800331, -3.774628, -3.774628, -4.075852, -4.075852, -2.604948, -2.604948, -0.3749661, -0.3749661 };
    List<double> y_values = new List<double>() { 1.007614, 1.007614, 1.236008, 1.236008, 1.90071, 1.90071, 1.486328, 1.486328, 3.361842, 3.361842, -1.993783, -1.993783, 3.287464, 3.287464, 3.78746, 3.78746, 1.398559, 1.398559, -0.5633316, -0.5633316, 2.168895, 2.168895, 3.953413, 3.953413, 0.7106715, 0.7106715, 1.855381, 1.855381, 3.896477, 3.896477, 0.1209861, 0.1209861, -1.89426, -1.89426, -0.07636511, -0.07636511, 1.799906, 1.799906, 0.2423922, 0.2423922, 0.6630462, 0.6630462, -0.08711398, -0.08711398, 0.04461253, 0.04461253, 1.750958, 1.750958, -1.714784, -1.714784, 1.364144, 1.364144, -1.829565, -1.829565, -1.623587, -1.623587, 2.776918, 2.776918, -1.41198, -1.41198, 1.032058, 1.032058, -0.03343117, -0.03343117, 2.557932, 2.557932, -0.7676673, -0.7676673, -1.981487, -1.981487, 0.8001629, 0.8001629, 3.31558, 3.31558, 0.3710231, 0.3710231, -0.153921, -0.153921, 2.822035, 2.822035, -1.568009, -1.568009, 1.050212, 1.050212, 1.950164, 1.950164, -1.256258, -1.256258, -0.8268182, -0.8268182, 0.7326757, 0.7326757, -1.18764, -1.18764, 3.814322, 3.814322, 1.817846, 1.817846, -0.1191911, -0.1191911, -1.904944, -1.904944, -1.547154, -1.547154, -0.07601607, -0.07601607, -1.083631, -1.083631, 3.940692, 3.940692, -1.20684, -1.20684, -1.437195, -1.437195, 1.155031, 1.155031, 1.607313, 1.607313, -0.5082304, -0.5082304, 3.72994, 3.72994, 3.750696, 3.750696, 1.47966, 1.47966, -0.01528943, -0.01528943, 1.960749, 1.960749, 3.998592, 3.998592, -0.9618549, -0.9618549, 1.074536, 1.074536, -0.8563426, -0.8563426, -0.612391, -0.612391, -1.961581, -1.961581, 0.4333118, 0.4333118, 3.517688, 3.517688, 2.974891, 2.974891, 2.138548, 2.138548, 0.6666797, 0.6666797, -1.302935, -1.302935, 2.888237, 2.888237, -1.968105, -1.968105, 2.776099, 2.776099, -0.9236782, -0.9236782, 0.6393048, 0.6393048, 2.806232, 2.806232, 1.606725, 1.606725, 2.862449, 2.862449, 2.051728, 2.051728, -0.6017938, -0.6017938, 2.031117, 2.031117, -1.540628, -1.540628, 1.12004, 1.12004, 1.07585, 1.07585, 3.307098, 3.307098, 2.785256, 2.785256, 3.545624, 3.545624, 1.128289, 1.128289, 3.737728, 3.737728, -1.093825, -1.093825, -1.811139, -1.811139, 3.239079, 3.239079, 0.7606894, 0.7606894, -0.54111, -0.54111, -0.9950542, -0.9950542, 0.2044286, 0.2044286, 3.139984, 3.139984, -1.840265, -1.840265, -0.9644563, -0.9644563, -0.4272131, -0.4272131, -1.512856, -1.512856, 3.576916, 3.576916, 0.9881865, 0.9881865, -0.4509338, -0.4509338, 2.994828, 2.994828, 2.850227, 2.850227, -0.01868331, -0.01868331, 2.001291, 2.001291, -1.301119, -1.301119, -1.257465, -1.257465, 0.9568082, 0.9568082, 1.189193, 1.189193, 3.044815, 3.044815, -0.8248713, -0.8248713, 2.989377, 2.989377, -1.180351, -1.180351, 2.184963, 2.184963, -1.427475, -1.427475, 3.746028, 3.746028, 3.722429, 3.722429, 2.809471, 2.809471, 3.270023, 3.270023, 0.88491, 0.88491, 3.68415, 3.68415, -0.01211512, -0.01211512, -0.6763628, -0.6763628, -1.502661, -1.502661, -0.2636734, -0.2636734, 3.830914, 3.830914, -0.8336682, -0.8336682, 0.9992665, 0.9992665, 1.89667, 1.89667, -1.238333, -1.238333, 1.843136, 1.843136, 3.673404, 3.673404, 3.999077, 3.999077, 2.486332, 2.486332, 1.387482, 1.387482, 3.786815, 3.786815, -1.852885, -1.852885, -1.018129, -1.018129, -1.381747, -1.381747, -0.3355452, -0.3355452 };
    List<double> z_values = new List<double>() { 9.789424, 9.789424, 6.368006, 6.368006, 9.506174, 9.506174, 6.119711, 6.119711, 7.623171, 7.623171, 5.912811, 5.912811, 9.473955, 9.473955, 4.325974, 4.325974, 7.671019, 7.671019, 6.75098, 6.75098, 8.143531, 8.143531, 7.235602, 7.235602, 8.486785, 8.486785, 7.554744, 7.554744, 6.764667, 6.764667, 5.704015, 5.704015, 7.210917, 7.210917, 4.684045, 4.684045, 7.423331, 7.423331, 8.989726, 8.989726, 4.846088, 4.846088, 8.572909, 8.572909, 6.918664, 6.918664, 9.354198, 9.354198, 5.651544, 5.651544, 4.525785, 4.525785, 6.541398, 6.541398, 8.302108, 8.302108, 9.10645, 9.10645, 8.053023, 8.053023, 5.846436, 5.846436, 9.031464, 9.031464, 7.583577, 7.583577, 7.043788, 7.043788, 4.146181, 4.146181, 4.127963, 4.127963, 6.105063, 6.105063, 5.010138, 5.010138, 5.099714, 5.099714, 5.240369, 5.240369, 7.072386, 7.072386, 6.596532, 6.596532, 4.298775, 4.298775, 4.898928, 4.898928, 4.175233, 4.175233, 8.869874, 8.869874, 8.533896, 8.533896, 5.424714, 5.424714, 8.582977, 8.582977, 4.39997, 4.39997, 8.033959, 8.033959, 6.93134, 6.93134, 4.199506, 4.199506, 6.404624, 6.404624, 5.857236, 5.857236, 6.371066, 6.371066, 5.574341, 5.574341, 8.880082, 8.880082, 7.581806, 7.581806, 9.77422, 9.77422, 7.071802, 7.071802, 6.528457, 6.528457, 8.416261, 8.416261, 6.992835, 6.992835, 4.116677, 4.116677, 4.023511, 4.023511, 9.837583, 9.837583, 7.720007, 7.720007, 4.11821, 4.11821, 8.237816, 8.237816, 5.689524, 5.689524, 5.319425, 5.319425, 7.525981, 7.525981, 5.885065, 5.885065, 9.148767, 9.148767, 5.726391, 5.726391, 8.526336, 8.526336, 5.351926, 5.351926, 5.876292, 5.876292, 7.475247, 7.475247, 9.956524, 9.956524, 4.522049, 4.522049, 4.534265, 4.534265, 4.243278, 4.243278, 8.719618, 8.719618, 9.877383, 9.877383, 7.780639, 7.780639, 5.716235, 5.716235, 5.413424, 5.413424, 6.66602, 6.66602, 4.611236, 4.611236, 5.546376, 5.546376, 4.320646, 4.320646, 5.290529, 5.290529, 8.55052, 8.55052, 9.082911, 9.082911, 5.184185, 5.184185, 7.892846, 7.892846, 9.062696, 9.062696, 8.650843, 8.650843, 4.312033, 4.312033, 4.745398, 4.745398, 6.775241, 6.775241, 8.583916, 8.583916, 5.069499, 5.069499, 8.118466, 8.118466, 9.045034, 9.045034, 9.472478, 9.472478, 8.079605, 8.079605, 7.92954, 7.92954, 5.624094, 5.624094, 6.568871, 6.568871, 5.134099, 5.134099, 7.312904, 7.312904, 8.153406, 8.153406, 9.581765, 9.581765, 6.666289, 6.666289, 7.031272, 7.031272, 8.33531, 8.33531, 6.456701, 6.456701, 7.695217, 7.695217, 8.516128, 8.516128, 8.49329, 8.49329, 8.81738, 8.81738, 7.250202, 7.250202, 4.518479, 4.518479, 4.704317, 4.704317, 9.502382, 9.502382, 4.240839, 4.240839, 6.589403, 6.589403, 9.792976, 9.792976, 5.172774, 5.172774, 4.849631, 4.849631, 4.035398, 4.035398, 7.116246, 7.116246, 5.256542, 5.256542, 8.674029, 8.674029, 6.618023, 6.618023, 6.637963, 6.637963, 9.430331, 9.430331, 8.078339, 8.078339, 6.997339, 6.997339, 7.308782, 7.308782, 6.334566, 6.334566, 7.837441, 7.837441, 8.337477, 8.337477, 4.443246, 4.443246, 4.152371, 4.152371, 5.559512, 5.559512, 7.696404, 7.696404 };



    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        int nrBalls = nrStillBalls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            /*double x = UnityEngine.Random.Range(-5f, 5f);
            x_values.Add(x);
            double y = UnityEngine.Random.Range(-2f, 4f);
            y_values.Add(y);
            double z = UnityEngine.Random.Range(4f, 10f);
            z_values.Add(z);*/

            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            Instantiate(ballPrefab, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        /*Debug.Log(String.Join(",", new List<double>(x_values).ConvertAll(i => i.ToString().Replace(",",".")).ToArray()));
       Debug.Log(String.Join(",", new List<double>(y_values).ConvertAll(i => i.ToString().Replace(",", ".")).ToArray()));
       Debug.Log(String.Join(",", new List<double>(z_values).ConvertAll(i => i.ToString().Replace(",", ".")).ToArray()));*/

        nrBalls += nrMov1Balls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov1.GetComponent<Mov1>().setSpeed(speed);
            Instantiate(ballPrefabMov1, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov1bBalls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov1b.GetComponent<Mov1b>().setSpeed(speed);
            Instantiate(ballPrefabMov1b, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov2Balls * 2;
        for (; i < nrBalls; i = i + 2)
        {

            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov2.GetComponent<Mov2>().setSpeed(speed);
            Instantiate(ballPrefabMov2, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov2bBalls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov2b.GetComponent<Mov2b>().setSpeed(speed);
            Instantiate(ballPrefabMov2b, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov3Balls * 2;
        for (; i < nrMov3Balls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov3.GetComponent<Mov3>().setSpeed(speed);
            Instantiate(ballPrefabMov3, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov3bBalls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov3b.GetComponent<Mov3b>().setSpeed(speed);
            Instantiate(ballPrefabMov3b, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov4Balls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov4.GetComponent<Mov4>().setSpeed(speed);
            Instantiate(ballPrefabMov4, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov4bBalls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            ballPrefabMov4b.GetComponent<Mov4b>().setSpeed(speed);
            Instantiate(ballPrefabMov4b, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        nrBalls += nrMov5Balls * 2;
        for (; i < nrBalls; i = i + 2)
        {
            double x = x_values[i];
            double y = y_values[i];
            double z = z_values[i];
            Instantiate(ballPrefabMov5, new Vector3((float)x, (float)y, (float)z), Quaternion.identity);
        }
        GameObject.Find("SphereManager").GetComponent<SphereManager>().TargetUpdate();
    }

    // Update is called once per frame
    void Update()
    {

    }
}